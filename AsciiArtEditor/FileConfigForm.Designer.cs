namespace AsciiArtEditor
{
    partial class FileConfigForm
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
            label1 = new Label();
            widthBox = new NumericUpDown();
            label2 = new Label();
            heightBox = new NumericUpDown();
            okButton = new Button();
            cancelButton = new Button();
            alignButtonTL = new Button();
            alignButtonT = new Button();
            alignButtonTR = new Button();
            alignButtonR = new Button();
            alignButtonC = new Button();
            alignButtonL = new Button();
            alignButtonBR = new Button();
            alignButtonB = new Button();
            alignButtonBL = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)widthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Width";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // widthBox
            // 
            widthBox.Location = new Point(62, 17);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(120, 23);
            widthBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Height";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // heightBox
            // 
            heightBox.Location = new Point(62, 46);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(120, 23);
            heightBox.TabIndex = 4;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(8, 171);
            okButton.Name = "okButton";
            okButton.Size = new Size(112, 23);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(241, 171);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(105, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // alignButtonTL
            // 
            alignButtonTL.AccessibleName = "button1";
            alignButtonTL.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonTL.Location = new Point(6, 22);
            alignButtonTL.Name = "alignButtonTL";
            alignButtonTL.Size = new Size(35, 35);
            alignButtonTL.TabIndex = 8;
            alignButtonTL.UseVisualStyleBackColor = false;
            alignButtonTL.Click += alignButtonTL_Click;
            // 
            // alignButtonT
            // 
            alignButtonT.AccessibleName = "button1";
            alignButtonT.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonT.Location = new Point(47, 22);
            alignButtonT.Name = "alignButtonT";
            alignButtonT.Size = new Size(35, 35);
            alignButtonT.TabIndex = 9;
            alignButtonT.UseVisualStyleBackColor = false;
            alignButtonT.Click += alignButtonT_Click;
            // 
            // alignButtonTR
            // 
            alignButtonTR.AccessibleName = "button1";
            alignButtonTR.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonTR.Location = new Point(88, 22);
            alignButtonTR.Name = "alignButtonTR";
            alignButtonTR.Size = new Size(35, 35);
            alignButtonTR.TabIndex = 10;
            alignButtonTR.UseVisualStyleBackColor = false;
            alignButtonTR.Click += alignButtonTR_Click;
            // 
            // alignButtonR
            // 
            alignButtonR.AccessibleName = "button1";
            alignButtonR.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonR.Location = new Point(88, 63);
            alignButtonR.Name = "alignButtonR";
            alignButtonR.Size = new Size(35, 35);
            alignButtonR.TabIndex = 13;
            alignButtonR.UseVisualStyleBackColor = false;
            alignButtonR.Click += alignButtonR_Click;
            // 
            // alignButtonC
            // 
            alignButtonC.AccessibleName = "button1";
            alignButtonC.BackColor = Color.Black;
            alignButtonC.Location = new Point(47, 63);
            alignButtonC.Name = "alignButtonC";
            alignButtonC.Size = new Size(35, 35);
            alignButtonC.TabIndex = 12;
            alignButtonC.UseVisualStyleBackColor = false;
            alignButtonC.Click += alignButtonC_Click;
            // 
            // alignButtonL
            // 
            alignButtonL.AccessibleName = "button1";
            alignButtonL.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonL.Location = new Point(6, 63);
            alignButtonL.Name = "alignButtonL";
            alignButtonL.Size = new Size(35, 35);
            alignButtonL.TabIndex = 11;
            alignButtonL.UseVisualStyleBackColor = false;
            alignButtonL.Click += alignButtonL_Click;
            // 
            // alignButtonBR
            // 
            alignButtonBR.AccessibleName = "button1";
            alignButtonBR.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonBR.Location = new Point(88, 104);
            alignButtonBR.Name = "alignButtonBR";
            alignButtonBR.Size = new Size(35, 35);
            alignButtonBR.TabIndex = 16;
            alignButtonBR.UseVisualStyleBackColor = false;
            alignButtonBR.Click += alignButtonBR_Click;
            // 
            // alignButtonB
            // 
            alignButtonB.AccessibleName = "button1";
            alignButtonB.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonB.Location = new Point(47, 104);
            alignButtonB.Name = "alignButtonB";
            alignButtonB.Size = new Size(35, 35);
            alignButtonB.TabIndex = 15;
            alignButtonB.UseVisualStyleBackColor = false;
            alignButtonB.Click += alignButtonB_Click;
            // 
            // alignButtonBL
            // 
            alignButtonBL.AccessibleName = "button1";
            alignButtonBL.BackColor = Color.FromArgb(224, 224, 224);
            alignButtonBL.Location = new Point(6, 104);
            alignButtonBL.Name = "alignButtonBL";
            alignButtonBL.Size = new Size(35, 35);
            alignButtonBL.TabIndex = 14;
            alignButtonBL.UseVisualStyleBackColor = false;
            alignButtonBL.Click += alignButtonBL_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(widthBox);
            groupBox1.Controls.Add(heightBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 81);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Size";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(alignButtonTL);
            groupBox2.Controls.Add(alignButtonL);
            groupBox2.Controls.Add(alignButtonBR);
            groupBox2.Controls.Add(alignButtonR);
            groupBox2.Controls.Add(alignButtonBL);
            groupBox2.Controls.Add(alignButtonT);
            groupBox2.Controls.Add(alignButtonC);
            groupBox2.Controls.Add(alignButtonTR);
            groupBox2.Controls.Add(alignButtonB);
            groupBox2.Location = new Point(217, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(129, 147);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resize Anchor";
            // 
            // FileConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(355, 206);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Name = "FileConfigForm";
            Text = "File Config";
            Load += FileConfigForm_Load;
            ((System.ComponentModel.ISupportInitialize)widthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button okButton;
        private Button cancelButton;
        private Button alignButtonTL;
        private Button alignButtonT;
        private Button alignButtonTR;
        private Button alignButtonR;
        private Button alignButtonC;
        private Button alignButtonL;
        private Button alignButtonBR;
        private Button alignButtonB;
        private Button alignButtonBL;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        public NumericUpDown widthBox;
        public NumericUpDown heightBox;
    }
}