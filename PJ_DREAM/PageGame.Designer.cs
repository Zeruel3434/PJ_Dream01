namespace PJ_DREAM
{
    partial class PageGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNext = new Button();
            txtText = new TextBox();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tapRead = new TabPage();
            tabLog = new TabPage();
            txtLog = new TextBox();
            btnReturnTitle = new Button();
            btnChoice1 = new Button();
            btnChoice2 = new Button();
            btnChoice3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tapRead.SuspendLayout();
            tabLog.SuspendLayout();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.AutoEllipsis = true;
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(870, 409);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 42);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtText
            // 
            txtText.Anchor = AnchorStyles.None;
            txtText.Enabled = false;
            txtText.ForeColor = Color.Black;
            txtText.HideSelection = false;
            txtText.Location = new Point(0, 1);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.ReadOnly = true;
            txtText.Size = new Size(719, 191);
            txtText.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BackgroundImage = Properties.Resources.Home_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.ImageLocation = "0,0";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(119, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(830, 349);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tapRead);
            tabControl1.Controls.Add(tabLog);
            tabControl1.Location = new Point(115, 385);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(727, 219);
            tabControl1.TabIndex = 4;
            // 
            // tapRead
            // 
            tapRead.Controls.Add(txtText);
            tapRead.Location = new Point(4, 24);
            tapRead.Name = "tapRead";
            tapRead.Padding = new Padding(3);
            tapRead.Size = new Size(719, 191);
            tapRead.TabIndex = 0;
            tapRead.Text = "Read";
            tapRead.UseVisualStyleBackColor = true;
            // 
            // tabLog
            // 
            tabLog.Controls.Add(txtLog);
            tabLog.Location = new Point(4, 24);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(3);
            tabLog.Size = new Size(719, 191);
            tabLog.TabIndex = 1;
            tabLog.Text = "Log";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.None;
            txtLog.BackColor = SystemColors.Control;
            txtLog.ImeMode = ImeMode.NoControl;
            txtLog.Location = new Point(0, 0);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(719, 188);
            txtLog.TabIndex = 5;
            // 
            // btnReturnTitle
            // 
            btnReturnTitle.Anchor = AnchorStyles.None;
            btnReturnTitle.ForeColor = Color.Black;
            btnReturnTitle.Location = new Point(870, 480);
            btnReturnTitle.Name = "btnReturnTitle";
            btnReturnTitle.Size = new Size(75, 41);
            btnReturnTitle.TabIndex = 5;
            btnReturnTitle.Text = "Title";
            btnReturnTitle.UseVisualStyleBackColor = true;
            btnReturnTitle.Click += btnReturnTitle_Click;
            // 
            // btnChoice1
            // 
            btnChoice1.Anchor = AnchorStyles.None;
            btnChoice1.ForeColor = Color.Black;
            btnChoice1.Location = new Point(115, 628);
            btnChoice1.Name = "btnChoice1";
            btnChoice1.Size = new Size(723, 39);
            btnChoice1.TabIndex = 6;
            btnChoice1.Text = "(1)";
            btnChoice1.UseVisualStyleBackColor = true;
            btnChoice1.Visible = false;
            btnChoice1.Click += btnChoice1_Click;
            // 
            // btnChoice2
            // 
            btnChoice2.Anchor = AnchorStyles.None;
            btnChoice2.ForeColor = Color.Black;
            btnChoice2.Location = new Point(111, 691);
            btnChoice2.Name = "btnChoice2";
            btnChoice2.Size = new Size(727, 39);
            btnChoice2.TabIndex = 7;
            btnChoice2.Text = "(2)";
            btnChoice2.UseVisualStyleBackColor = true;
            btnChoice2.Visible = false;
            btnChoice2.Click += btnChoice2_Click;
            // 
            // btnChoice3
            // 
            btnChoice3.Anchor = AnchorStyles.None;
            btnChoice3.ForeColor = Color.Black;
            btnChoice3.Location = new Point(111, 754);
            btnChoice3.Name = "btnChoice3";
            btnChoice3.Size = new Size(727, 39);
            btnChoice3.TabIndex = 8;
            btnChoice3.Text = "(3)";
            btnChoice3.UseVisualStyleBackColor = true;
            btnChoice3.Visible = false;
            btnChoice3.Click += btnChoice3_Click;
            // 
            // PageGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gray;
            Controls.Add(btnChoice3);
            Controls.Add(btnChoice2);
            Controls.Add(btnReturnTitle);
            Controls.Add(btnChoice1);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Name = "PageGame";
            Size = new Size(1071, 829);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tapRead.ResumeLayout(false);
            tapRead.PerformLayout();
            tabLog.ResumeLayout(false);
            tabLog.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNext;
        private TextBox txtText;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tapRead;
        private TabPage tabLog;
        private TextBox txtLog;
        private Button btnReturnTitle;
        private Button btnChoice1;
        private Button btnChoice2;
        private Button btnChoice3;
    }
}
