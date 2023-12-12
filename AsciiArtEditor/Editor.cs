using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AsciiArtEditor.AsciiArt;

namespace AsciiArtEditor
{
    public enum Tool
    {
        Paint,
        Select,
        Recolor,
        Rechar,
        Erase
    }
    public partial class Editor : Form
    {
        int selectionStartX, selectionStartY = 0;
        int selectionEndX, selectionEndY = 0;
        bool isSelecting = false;
        bool hasSelection = false;
        bool isMouseLDownInCanvas = false;
        bool isMouseRDownInCanvas = false;
        int mouseX, mouseY = 0;
        public Tool cTool = Tool.Paint;

        public static string documentFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HURP");

        private string lastRTF = "";
        Dictionary<string, string> charPalette = new Dictionary<string, string>();

        //string charPalette = "";
        public Editor()
        {
            charPalette.Add("Blocks", " █▓▒░▀▄▌▐◘");
            charPalette.Add("Widgets", "●○◌◙■□▪▫⌂∆▲▼◄►▴▾◂▸«»˂˃˄˅∑≡≤≥↔↕↨←↑→↓µ✶ﬗﬖ₼☼♠♣♥♦◊ІΞͼͽϵ϶ЖДхж");
            charPalette.Add("Symbols", "Λ∕∙∩ↃↄΩ₷⃰•⁞ᴥҬҭѦѧ҈҉ФΦϪϫϞϟλͶͷ¶§ʕʔˀҖҗ√∫∏¥£¢¤ˁº±°¯ª¨θѺѻ");
            charPalette.Add("Pipes (Thin)", "╭╮╰╯┌┐└┘├┤┬┴─│┼╵╷╶╴╲╱╳");
            charPalette.Add("Pipes (Thick)", "┏┓┗┛┣┫┳┻━┃╋╹╻╺╸");
            charPalette.Add("Pipes (Double)", "╔╗╚╝╠╣╦╩═║╬");
            charPalette.Add("Pipes (Connecting)", "╒╕╘╛╡╞╤╧╪╓╖╙╜╟╢╥╨╫╼╾╿╽");
            charPalette.Add("Pipes (Special)", "┊┋┆┇┄┅⌠⌡¦˭˽");
            charPalette.Add("Capital", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            charPalette.Add("Lowercase", "abcdefghijklmnopqrstuvwxyz1234567890");
            charPalette.Add("Numeric", "1234567890");
            charPalette.Add("Punctuation", "()[]{}<>\"':;~`!¡@#$%^&*-=_+\\|/?‽ʽʼʻ");
            InitializeComponent();
        }

        private string GetPreviewRTF()
        {
            string rtfstr = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Consolas;}}\n";
            rtfstr += "{\\colortbl";
            foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
            {
                Color col = Util.ToColor(cc);
                rtfstr += "\\red" + col.R + "\\green" + col.G + "\\blue" + col.B + ";";
            }
            rtfstr += "\\red20\\green50\\blue80;"; //selection color
            rtfstr += "}\n";

            //selection
            int minX = Math.Min(selectionStartX, selectionEndX);
            int minY = Math.Min(selectionStartY, selectionEndY);
            int maxX = Math.Max(selectionStartX, selectionEndX);
            int maxY = Math.Max(selectionStartY, selectionEndY);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    CharInfo charInfo = AsciiArt.characters[x, y];
                    rtfstr += "{\\chshdng10000\\chcbpat" + (int)charInfo.BG + "\\cf" + (int)charInfo.FG;
                    if ((isSelecting || hasSelection) && x >= minX && x <= maxX && y >= minY && y <= maxY)
                        rtfstr += "\\ulth\\shad\\chcbpat" + 16;
                    if (charInfo.character == null || charInfo.character == " ")
                    {
                        rtfstr += "\\cf" + (int)charInfo.BG + ".";
                    }
                    else
                    {
                        rtfstr += charInfo.character;
                    }
                    rtfstr += "}";
                }
                if (y < height - 1)
                {
                    rtfstr += "\\line";
                }
            }
            rtfstr += "}";
            return rtfstr;
        }
        private void Editor_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(documentFolder))
            {
                Directory.CreateDirectory(documentFolder);
            }
            openFileDialog1.InitialDirectory = documentFolder;
            saveFileDialog1.InitialDirectory = documentFolder;

            FGColorSelectorListView.Items.Clear();
            BGColorSelectorListView.Items.Clear();
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                FGColorSelectorListView.Items.Add(new ListViewItem(new String[] { c.ToString() }, 0, Util.ToColor(c), Util.ToColor(c), Editor.DefaultFont));
                BGColorSelectorListView.Items.Add(new ListViewItem(new String[] { c.ToString() }, 0, Util.ToColor(c), Util.ToColor(c), Editor.DefaultFont));
            }
            CharPaletteListView.Items.Clear();
            foreach (string category in charPalette.Keys)
            {
                ListViewGroup g = new ListViewGroup(category);
                foreach (char c in charPalette[category])
                {
                    CharPaletteListView.Items.Add(new ListViewItem(new String[] { c.ToString() }, 0, Util.ToColor(ConsoleColor.White), Util.ToColor(ConsoleColor.Black), this.Font, g));
                }
                CharPaletteListView.Groups.Add(g);
            }
            AsciiArt.Init();
            //richTextBox1.Rtf = GetPreviewRTF();
            updateTimer.Start();
            RefreshBrushPreviews();
        }

        private void DoSave()
        {
            if (AsciiArt.cFilePath == "")
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                AsciiArt.cFilePath = saveFileDialog1.FileName;
                AsciiArt.cFileName = saveFileDialog1.FileName.Split(Path.DirectorySeparatorChar).Last();
            }
            AsciiArt.Save(AsciiArt.cFilePath);
            canvasControl1.Refresh();
        }
        private void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            AsciiArt.cFilePath = saveFileDialog1.FileName;
            AsciiArt.cFileName = saveFileDialog1.FileName.Split(Path.DirectorySeparatorChar).Last();
            MessageBox.Show(AsciiArt.cFilePath);
            AsciiArt.Save(AsciiArt.cFilePath);
            canvasControl1.Refresh();
        }
        private void DoOpen()
        {
            if (AsciiArt.hasUnsavedChanges)
            {
                if (MessageBox.Show("You have unsaved work! Opening a new file will close this one without saving.", "UNSAVED WORK!", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return; //cancelled
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AsciiArt.LoadFile(openFileDialog1.FileName);
                AsciiArt.cFilePath = openFileDialog1.FileName;
                AsciiArt.cFileName = openFileDialog1.FileName.Split(Path.DirectorySeparatorChar).Last();
                canvasControl1.Refresh();
                AsciiArt.ClearUndo();
            }
        }
        private void DoNew()
        {
            if (AsciiArt.hasUnsavedChanges)
            {
                if (MessageBox.Show("You have unsaved work! Creating a new file will close this one without saving.", "UNSAVED WORK!", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return; //cancelled
                }
            }
            FileConfigForm form = new FileConfigForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AsciiArt.cFilePath = "";
                AsciiArt.cFileName = "Untitled.hurp";
                AsciiArt.width = (int)form.widthBox.Value;
                AsciiArt.height = (int)form.heightBox.Value;
                AsciiArt.CreateBlankFile();
                canvasControl1.Refresh();
                AsciiArt.ClearUndo();
            }
            form.Dispose();
        }

        private void DoResize()
        {
            AsciiArt.AddUndoState();
            FileConfigForm form = new FileConfigForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AsciiArt.cFilePath = "";
                AsciiArt.cFileName = "Untitled.hurp";
                AsciiArt.ResizeH((int)form.widthBox.Value, form.cAlignX);
                AsciiArt.ResizeV((int)form.heightBox.Value, form.cAlignY);
                canvasControl1.Refresh();
            }
            form.Dispose();
        }
        private void DoUndo()
        {
            AsciiArt.Undo();
            canvasControl1.Refresh();
        }
        private void DoRedo()
        {
            AsciiArt.Redo();
            canvasControl1.Refresh();
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            this.Focus();
            //richTextBox1.SelectionStart = 0;
            //richTextBox1.SelectionLength = 0;

            mouseX = e.X / canvasControl1.charWidth;
            mouseY = e.Y / canvasControl1.charHeight;
            //Console.WriteLine(mouseX + ", " + mouseY);

            AsciiArt.cursorX = mouseX; AsciiArt.cursorY = mouseY;

            switch (cTool)
            {
                case Tool.Select:
                    if (isSelecting)
                    {
                        selectionEndX = mouseX;
                        selectionEndY = mouseY;
                    }
                    break;
                case Tool.Paint:
                    if (isMouseLDownInCanvas)
                        AsciiArt.SetCharacter(mouseX, mouseY, AsciiArt.brush);
                    if (isMouseRDownInCanvas)
                        AsciiArt.SetCharacter(mouseX, mouseY, AsciiArt.brush2);
                    break;
            }

            string rtf = GetPreviewRTF();
            if (lastRTF != rtf)
            {
                //richTextBox1.Rtf = rtf;
                lastRTF = rtf;
                if (isSelecting)
                {
                    //Console.Beep(500, 10);
                }
            }
            if (isSelecting || hasSelection)
            {
                AsciiArt.selectionMinX = Math.Min(selectionStartX, selectionEndX);
                AsciiArt.selectionMinY = Math.Min(selectionStartY, selectionEndY);
                AsciiArt.selectionMaxX = Math.Max(selectionStartX, selectionEndX);
                AsciiArt.selectionMaxY = Math.Max(selectionStartY, selectionEndY);
            }
            else
            {
                AsciiArt.selectionMinX = -1;
                AsciiArt.selectionMinY = -1;
                AsciiArt.selectionMaxX = -1;
                AsciiArt.selectionMaxY = -1;
            }

            canvasControl1.Refresh();
        }
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseLDownInCanvas = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                isMouseRDownInCanvas = true;
            }
            switch (cTool)
            {
                case Tool.Select:
                    if (e.Button == MouseButtons.Left)
                    {
                        isSelecting = true;
                        hasSelection = false;
                        selectionStartX = mouseX;
                        selectionStartY = mouseY;
                        selectionEndX = mouseX;
                        selectionEndY = mouseY;
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        isSelecting = false;
                        hasSelection = false;
                        selectionStartX = -1;
                        selectionStartY = -1;
                        selectionEndX = -1;
                        selectionEndY = -1;
                    }
                    break;
                case Tool.Paint:
                    AsciiArt.AddUndoState();
                    if (isMouseLDownInCanvas)
                        AsciiArt.SetCharacter(mouseX, mouseY, AsciiArt.brush);
                    if (isMouseRDownInCanvas)
                        AsciiArt.SetCharacter(mouseX, mouseY, AsciiArt.brush2);
                    break;
            }
        }
        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseLDownInCanvas = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
                isMouseRDownInCanvas = false;
            }
            switch (cTool)
            {
                case Tool.Select:
                    if (isSelecting != true) return;
                    hasSelection = true;
                    isSelecting = false;
                    selectionEndX = mouseX;
                    selectionEndY = mouseY;
                    break;
            }
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
            Console.WriteLine(AsciiArt.cFileName + "");
            for(int i = 0; i < AsciiArt.width-AsciiArt.cFileName.Length; i++)
            {
                Console.Write(" ");
            }
            AsciiArt.DisplayArt();
            this.Text = AsciiArt.cFileName + (AsciiArt.hasUnsavedChanges ? "*" : "") + " - Hadley's Unicode Resource Project";
        }

        private void paintButton_Click(object sender, EventArgs e)
        {
            cTool = Tool.Paint;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            cTool = Tool.Select;
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                Console.ResetColor();
                DoSave();
            }
            else if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                Console.ResetColor();
                DoOpen();
            }
            else if (e.KeyCode == Keys.Y && e.Modifiers == Keys.Control)
            {
                Console.ResetColor();
                DoRedo();
            }
            else if (e.KeyCode == Keys.Z && e.Modifiers == (Keys.Control | Keys.Shift))
            {
                Console.ResetColor();
                DoRedo();
            }
            else if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                Console.ResetColor();
                DoUndo();
            }
            else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                Console.ResetColor();
                DoNew();
            }
        }

        private void RefreshBrushPreviews()
        {
            previewLabelL.BackColor = Util.ToColor(AsciiArt.brush.BG);
            previewLabelL.ForeColor = Util.ToColor(AsciiArt.brush.FG);
            previewLabelL.Text = AsciiArt.brush.character;

            previewLabelR.BackColor = Util.ToColor(AsciiArt.brush2.BG);
            previewLabelR.ForeColor = Util.ToColor(AsciiArt.brush2.FG);
            previewLabelR.Text = AsciiArt.brush2.character;
        }

        private void CharPaletteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                if (CharPaletteListView.SelectedItems.Count >= 1)
                {
                    AsciiArt.brush.character = CharPaletteListView.SelectedItems[0].Text;
                }
            }
            else if (MouseButtons == MouseButtons.Right)
            {
                if (CharPaletteListView.SelectedItems.Count >= 1)
                {
                    AsciiArt.brush2.character = CharPaletteListView.SelectedItems[0].Text;
                }
            }
            RefreshBrushPreviews();
        }

        private void FGColorSelectorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                if (FGColorSelectorListView.SelectedItems.Count >= 1)
                {
                    AsciiArt.brush.FG = Enum.Parse<ConsoleColor>(FGColorSelectorListView.SelectedItems[0].Text);
                }
            }
            else if (MouseButtons == MouseButtons.Right)
            {
                if (FGColorSelectorListView.SelectedItems.Count >= 1)
                {
                    AsciiArt.brush2.FG = Enum.Parse<ConsoleColor>(FGColorSelectorListView.SelectedItems[0].Text);
                }
            }
            RefreshBrushPreviews();
        }

        private void BGColorSelectorListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                if (BGColorSelectorListView.SelectedItems.Count >= 1)
                {
                    AsciiArt.brush.BG = Enum.Parse<ConsoleColor>(BGColorSelectorListView.SelectedItems[0].Text);
                }
            }
            else if (MouseButtons == MouseButtons.Right)
            {
                if (BGColorSelectorListView.SelectedItems.Count >= 1)
                {
                    AsciiArt.brush2.BG = Enum.Parse<ConsoleColor>(BGColorSelectorListView.SelectedItems[0].Text);
                }
            }
            RefreshBrushPreviews();
        }

        private void canvasControl1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void canvasControl1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown(sender, e);
        }

        private void canvasControl1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp(sender, e);
        }

        private void resizeCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoResize();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoNew();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoSave();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoSaveAs();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoOpen();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoUndo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoRedo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
