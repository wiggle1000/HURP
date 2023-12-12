namespace AsciiArtEditor
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "Red" }, -1, Color.Empty, Color.Red, null);
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "DarkRed" }, -1, Color.Empty, Color.Maroon, null);
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "Red" }, -1, Color.Empty, Color.Red, null);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "DarkRed" }, -1, Color.Empty, Color.Maroon, null);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "&" }, -1, Color.Empty, Color.FromArgb(64, 64, 64), null);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "@" }, -1, Color.Empty, Color.FromArgb(64, 64, 64), null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            button5 = new Button();
            selectButton = new Button();
            button3 = new Button();
            button2 = new Button();
            paintButton = new Button();
            splitContainer6 = new SplitContainer();
            groupBox3 = new GroupBox();
            previewLabelL = new Label();
            groupBox4 = new GroupBox();
            previewLabelR = new Label();
            splitContainer4 = new SplitContainer();
            groupBox1 = new GroupBox();
            FGColorSelectorListView = new ListView();
            groupBox2 = new GroupBox();
            BGColorSelectorListView = new ListView();
            splitContainer2 = new SplitContainer();
            canvasControl1 = new CanvasControl();
            CharPaletteListView = new ListView();
            toolStripContainer1 = new ToolStripContainer();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            resizeCanvasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            updateTimer = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(927, 495);
            splitContainer1.SplitterDistance = 184;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.Fixed3D;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(4);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer7);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(184, 495);
            splitContainer3.SplitterDistance = 302;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = DockStyle.Fill;
            splitContainer7.FixedPanel = FixedPanel.Panel1;
            splitContainer7.IsSplitterFixed = true;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.Name = "splitContainer7";
            splitContainer7.Orientation = Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(splitContainer5);
            splitContainer7.Size = new Size(180, 298);
            splitContainer7.SplitterDistance = 252;
            splitContainer7.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.BorderStyle = BorderStyle.Fixed3D;
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(button5);
            splitContainer5.Panel1.Controls.Add(selectButton);
            splitContainer5.Panel1.Controls.Add(button3);
            splitContainer5.Panel1.Controls.Add(button2);
            splitContainer5.Panel1.Controls.Add(paintButton);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer6);
            splitContainer5.Size = new Size(180, 252);
            splitContainer5.SplitterDistance = 91;
            splitContainer5.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(0, 89);
            button5.Name = "button5";
            button5.Size = new Size(87, 56);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            selectButton.Dock = DockStyle.Top;
            selectButton.Location = new Point(0, 45);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(87, 44);
            selectButton.TabIndex = 3;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.Location = new Point(0, 145);
            button3.Name = "button3";
            button3.Size = new Size(87, 51);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 196);
            button2.Name = "button2";
            button2.Size = new Size(87, 52);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // paintButton
            // 
            paintButton.Dock = DockStyle.Top;
            paintButton.Location = new Point(0, 0);
            paintButton.Name = "paintButton";
            paintButton.Size = new Size(87, 45);
            paintButton.TabIndex = 0;
            paintButton.Text = "Paint";
            paintButton.UseVisualStyleBackColor = true;
            paintButton.Click += paintButton_Click;
            // 
            // splitContainer6
            // 
            splitContainer6.BorderStyle = BorderStyle.FixedSingle;
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.IsSplitterFixed = true;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(groupBox4);
            splitContainer6.Size = new Size(81, 248);
            splitContainer6.SplitterDistance = 116;
            splitContainer6.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(previewLabelL);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(79, 114);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Left";
            // 
            // previewLabelL
            // 
            previewLabelL.BackColor = Color.White;
            previewLabelL.BorderStyle = BorderStyle.Fixed3D;
            previewLabelL.Dock = DockStyle.Fill;
            previewLabelL.Font = new Font("Consolas", 48F, FontStyle.Regular, GraphicsUnit.Point);
            previewLabelL.ForeColor = Color.Maroon;
            previewLabelL.Location = new Point(3, 22);
            previewLabelL.Margin = new Padding(0);
            previewLabelL.Name = "previewLabelL";
            previewLabelL.Padding = new Padding(8, 0, 0, 0);
            previewLabelL.Size = new Size(73, 89);
            previewLabelL.TabIndex = 0;
            previewLabelL.Text = "┼";
            previewLabelL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(previewLabelR);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(79, 126);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Right";
            // 
            // previewLabelR
            // 
            previewLabelR.BackColor = Color.White;
            previewLabelR.BorderStyle = BorderStyle.Fixed3D;
            previewLabelR.Dock = DockStyle.Fill;
            previewLabelR.Font = new Font("Consolas", 48F, FontStyle.Regular, GraphicsUnit.Point);
            previewLabelR.ForeColor = Color.Maroon;
            previewLabelR.Location = new Point(3, 22);
            previewLabelR.Margin = new Padding(0);
            previewLabelR.Name = "previewLabelR";
            previewLabelR.Padding = new Padding(8, 0, 0, 0);
            previewLabelR.Size = new Size(73, 101);
            previewLabelR.TabIndex = 1;
            previewLabelR.Text = "┼";
            previewLabelR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer4
            // 
            splitContainer4.BorderStyle = BorderStyle.FixedSingle;
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.IsSplitterFixed = true;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(4);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(groupBox2);
            splitContainer4.Size = new Size(180, 184);
            splitContainer4.SplitterDistance = 80;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FGColorSelectorListView);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(178, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "FG Color";
            // 
            // FGColorSelectorListView
            // 
            FGColorSelectorListView.BackColor = Color.FromArgb(64, 64, 64);
            FGColorSelectorListView.Dock = DockStyle.Fill;
            FGColorSelectorListView.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FGColorSelectorListView.ForeColor = Color.White;
            FGColorSelectorListView.FullRowSelect = true;
            FGColorSelectorListView.GridLines = true;
            FGColorSelectorListView.Items.AddRange(new ListViewItem[] { listViewItem9, listViewItem10 });
            FGColorSelectorListView.Location = new Point(4, 23);
            FGColorSelectorListView.Margin = new Padding(4);
            FGColorSelectorListView.MultiSelect = false;
            FGColorSelectorListView.Name = "FGColorSelectorListView";
            FGColorSelectorListView.Scrollable = false;
            FGColorSelectorListView.Size = new Size(170, 51);
            FGColorSelectorListView.TabIndex = 1;
            FGColorSelectorListView.TileSize = new Size(20, 20);
            FGColorSelectorListView.UseCompatibleStateImageBehavior = false;
            FGColorSelectorListView.View = View.Tile;
            FGColorSelectorListView.SelectedIndexChanged += FGColorSelectorListView_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BGColorSelectorListView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(178, 97);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BG Color";
            // 
            // BGColorSelectorListView
            // 
            BGColorSelectorListView.BackColor = Color.FromArgb(64, 64, 64);
            BGColorSelectorListView.Dock = DockStyle.Fill;
            BGColorSelectorListView.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BGColorSelectorListView.ForeColor = Color.White;
            BGColorSelectorListView.FullRowSelect = true;
            BGColorSelectorListView.GridLines = true;
            BGColorSelectorListView.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12 });
            BGColorSelectorListView.Location = new Point(4, 23);
            BGColorSelectorListView.Margin = new Padding(4);
            BGColorSelectorListView.MultiSelect = false;
            BGColorSelectorListView.Name = "BGColorSelectorListView";
            BGColorSelectorListView.Scrollable = false;
            BGColorSelectorListView.Size = new Size(170, 70);
            BGColorSelectorListView.TabIndex = 2;
            BGColorSelectorListView.TileSize = new Size(20, 20);
            BGColorSelectorListView.UseCompatibleStateImageBehavior = false;
            BGColorSelectorListView.View = View.Tile;
            BGColorSelectorListView.SelectedIndexChanged += BGColorSelectorListView_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(canvasControl1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(CharPaletteListView);
            splitContainer2.Size = new Size(734, 491);
            splitContainer2.SplitterDistance = 265;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // canvasControl1
            // 
            canvasControl1.BackColor = Color.Black;
            canvasControl1.Dock = DockStyle.Fill;
            canvasControl1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            canvasControl1.Location = new Point(0, 0);
            canvasControl1.Margin = new Padding(3, 4, 3, 4);
            canvasControl1.Name = "canvasControl1";
            canvasControl1.Size = new Size(732, 263);
            canvasControl1.TabIndex = 0;
            canvasControl1.MouseDown += canvasControl1_MouseDown;
            canvasControl1.MouseMove += canvasControl1_MouseMove;
            canvasControl1.MouseUp += canvasControl1_MouseUp;
            // 
            // CharPaletteListView
            // 
            CharPaletteListView.BackColor = Color.Black;
            CharPaletteListView.Dock = DockStyle.Fill;
            CharPaletteListView.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CharPaletteListView.ForeColor = Color.White;
            CharPaletteListView.FullRowSelect = true;
            CharPaletteListView.GridLines = true;
            CharPaletteListView.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8 });
            CharPaletteListView.Location = new Point(0, 0);
            CharPaletteListView.Margin = new Padding(4);
            CharPaletteListView.MultiSelect = false;
            CharPaletteListView.Name = "CharPaletteListView";
            CharPaletteListView.Size = new Size(732, 219);
            CharPaletteListView.TabIndex = 0;
            CharPaletteListView.TileSize = new Size(20, 25);
            CharPaletteListView.UseCompatibleStateImageBehavior = false;
            CharPaletteListView.View = View.Tile;
            CharPaletteListView.SelectedIndexChanged += CharPaletteListView_SelectedIndexChanged;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Margin = new Padding(4);
            toolStripContainer1.ContentPanel.Size = new Size(927, 495);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Margin = new Padding(4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(927, 520);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton2, toolStripSeparator1, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(127, 25);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, openToolStripMenuItem, toolStripMenuItem6, resizeCanvasToolStripMenuItem });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(38, 22);
            toolStripDropDownButton2.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(147, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(147, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(147, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(147, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(147, 22);
            toolStripMenuItem6.Text = "________";
            // 
            // resizeCanvasToolStripMenuItem
            // 
            resizeCanvasToolStripMenuItem.Name = "resizeCanvasToolStripMenuItem";
            resizeCanvasToolStripMenuItem.Size = new Size(147, 22);
            resizeCanvasToolStripMenuItem.Text = "Resize Canvas";
            resizeCanvasToolStripMenuItem.Click += resizeCanvasToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem5, copyToolStripMenuItem, pasteToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(40, 22);
            toolStripDropDownButton1.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(180, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(180, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "________";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(180, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // updateTimer
            // 
            updateTimer.Tick += updateTimer_Tick;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "HURP documents (*.hurp)|*.hurp|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "HURP documents (*.hurp)|*.hurp|All files (*.*)|*.*";
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(927, 520);
            Controls.Add(toolStripContainer1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "Editor";
            Text = "Untitled.hurp* - Hadley's Unicode Resource Producer";
            Load += Editor_Load;
            KeyDown += Editor_KeyDown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListView CharPaletteListView;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ListView FGColorSelectorListView;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView BGColorSelectorListView;
        private SplitContainer splitContainer5;
        private Button button3;
        private Button button2;
        private Button paintButton;
        private Button selectButton;
        private Button button5;
        private System.Windows.Forms.Timer updateTimer;
        private Label previewLabelL;
        private SplitContainer splitContainer6;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label previewLabelR;
        private CanvasControl canvasControl1;
        private SplitContainer splitContainer7;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem resizeCanvasToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
    }
}