using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiArtEditor
{
    public partial class FileConfigForm : Form
    {
        Color buttonInactiveColor = Color.FromArgb(224, 224, 224);
        Color buttonActiveColor = Color.FromArgb(10, 10, 10);
        public int cAlignX = 0;
        public int cAlignY = 0;

        public FileConfigForm()
        {
            InitializeComponent();
        }

        private void FileConfigForm_Load(object sender, EventArgs e)
        {
            widthBox.Value = AsciiArt.width;
            heightBox.Value = AsciiArt.height;
        }

        private void disableAllAlignButtons()
        {
            alignButtonTL.BackColor = buttonInactiveColor;
            alignButtonT.BackColor = buttonInactiveColor;
            alignButtonTR.BackColor = buttonInactiveColor;
            alignButtonL.BackColor = buttonInactiveColor;
            alignButtonC.BackColor = buttonInactiveColor;
            alignButtonR.BackColor = buttonInactiveColor;
            alignButtonBL.BackColor = buttonInactiveColor;
            alignButtonB.BackColor = buttonInactiveColor;
            alignButtonBR.BackColor = buttonInactiveColor;
        }

        private void alignButtonTL_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonTL.BackColor = buttonActiveColor;
            cAlignX = -1;
            cAlignY = -1;
        }

        private void alignButtonT_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonT.BackColor = buttonActiveColor;
            cAlignX = 0;
            cAlignY = -1;
        }

        private void alignButtonTR_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonTR.BackColor = buttonActiveColor;
            cAlignX = 1;
            cAlignY = -1;
        }

        private void alignButtonL_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonL.BackColor = buttonActiveColor;
            cAlignX = -1;
            cAlignY = 0;
        }

        private void alignButtonC_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonC.BackColor = buttonActiveColor;
            cAlignX = 0;
            cAlignY = 0;
        }

        private void alignButtonR_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonR.BackColor = buttonActiveColor;
            cAlignX = 1;
            cAlignY = 0;
        }

        private void alignButtonBL_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonBL.BackColor = buttonActiveColor;
            cAlignX = -1;
            cAlignY = 1;
        }

        private void alignButtonB_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonB.BackColor = buttonActiveColor;
            cAlignX = 0;
            cAlignY = 1;
        }

        private void alignButtonBR_Click(object sender, EventArgs e)
        {
            disableAllAlignButtons();
            alignButtonBR.BackColor = buttonActiveColor;
            cAlignX = 1;
            cAlignY = 1;
        }
    }
}
