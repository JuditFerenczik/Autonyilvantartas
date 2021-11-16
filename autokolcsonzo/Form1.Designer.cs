
namespace autokolcsonzo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioNem = new System.Windows.Forms.RadioButton();
            this.radioIgen = new System.Windows.Forms.RadioButton();
            this.muszaki = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listSzin = new System.Windows.Forms.ListBox();
            this.szin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textUzem = new System.Windows.Forms.TextBox();
            this.uzem = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textTips = new System.Windows.Forms.TextBox();
            this.tipus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textGyart = new System.Windows.Forms.TextBox();
            this.gyart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textRendsz = new System.Windows.Forms.TextBox();
            this.rendsz = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPanel.Controls.Add(this.panel8);
            this.MainPanel.Controls.Add(this.panel7);
            this.MainPanel.Controls.Add(this.panel6);
            this.MainPanel.Controls.Add(this.panel5);
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Location = new System.Drawing.Point(167, -14);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(341, 452);
            this.MainPanel.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(12, 27);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(305, 61);
            this.panel8.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "AUTÓ NYILVÁNTARTÁS";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(14, 380);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 55);
            this.panel7.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kiírás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioNem);
            this.panel6.Controls.Add(this.radioIgen);
            this.panel6.Controls.Add(this.muszaki);
            this.panel6.Location = new System.Drawing.Point(14, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(305, 34);
            this.panel6.TabIndex = 7;
            // 
            // radioNem
            // 
            this.radioNem.AutoSize = true;
            this.radioNem.Location = new System.Drawing.Point(214, 6);
            this.radioNem.Name = "radioNem";
            this.radioNem.Size = new System.Drawing.Size(51, 19);
            this.radioNem.TabIndex = 2;
            this.radioNem.TabStop = true;
            this.radioNem.Text = "Nem";
            this.radioNem.UseVisualStyleBackColor = true;
            // 
            // radioIgen
            // 
            this.radioIgen.AutoSize = true;
            this.radioIgen.Location = new System.Drawing.Point(144, 6);
            this.radioIgen.Name = "radioIgen";
            this.radioIgen.Size = new System.Drawing.Size(48, 19);
            this.radioIgen.TabIndex = 1;
            this.radioIgen.TabStop = true;
            this.radioIgen.Text = "Igen";
            this.radioIgen.UseVisualStyleBackColor = true;
            // 
            // muszaki
            // 
            this.muszaki.AutoSize = true;
            this.muszaki.Location = new System.Drawing.Point(3, 10);
            this.muszaki.Name = "muszaki";
            this.muszaki.Size = new System.Drawing.Size(135, 15);
            this.muszaki.TabIndex = 0;
            this.muszaki.Text = "Van e érvényes forgalmi:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listSzin);
            this.panel5.Controls.Add(this.szin);
            this.panel5.Location = new System.Drawing.Point(14, 292);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 42);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // listSzin
            // 
            this.listSzin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listSzin.FormattingEnabled = true;
            this.listSzin.ItemHeight = 15;
            this.listSzin.Items.AddRange(new object[] {
            "fekete",
            "ezüst",
            "piros",
            "zöld",
            "egyéb"});
            this.listSzin.Location = new System.Drawing.Point(71, 4);
            this.listSzin.Name = "listSzin";
            this.listSzin.Size = new System.Drawing.Size(226, 19);
            this.listSzin.TabIndex = 1;
            this.listSzin.SelectedIndexChanged += new System.EventHandler(this.listSzin_SelectedIndexChanged);
            // 
            // szin
            // 
            this.szin.AutoSize = true;
            this.szin.Location = new System.Drawing.Point(5, 8);
            this.szin.Name = "szin";
            this.szin.Size = new System.Drawing.Size(37, 15);
            this.szin.TabIndex = 0;
            this.szin.Text = "Színe:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textUzem);
            this.panel4.Controls.Add(this.uzem);
            this.panel4.Location = new System.Drawing.Point(14, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 34);
            this.panel4.TabIndex = 5;
            // 
            // textUzem
            // 
            this.textUzem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textUzem.Location = new System.Drawing.Point(146, 4);
            this.textUzem.Name = "textUzem";
            this.textUzem.Size = new System.Drawing.Size(150, 23);
            this.textUzem.TabIndex = 1;
            this.textUzem.Text = "2000.01.01";
            // 
            // uzem
            // 
            this.uzem.AutoSize = true;
            this.uzem.Location = new System.Drawing.Point(4, 4);
            this.uzem.Name = "uzem";
            this.uzem.Size = new System.Drawing.Size(135, 15);
            this.uzem.TabIndex = 0;
            this.uzem.Text = "Üzembehelyzés dátuma:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textTips);
            this.panel3.Controls.Add(this.tipus);
            this.panel3.Location = new System.Drawing.Point(13, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 34);
            this.panel3.TabIndex = 4;
            // 
            // textTips
            // 
            this.textTips.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textTips.Location = new System.Drawing.Point(71, 4);
            this.textTips.Name = "textTips";
            this.textTips.Size = new System.Drawing.Size(226, 23);
            this.textTips.TabIndex = 1;
            // 
            // tipus
            // 
            this.tipus.AutoSize = true;
            this.tipus.Location = new System.Drawing.Point(5, 4);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(38, 15);
            this.tipus.TabIndex = 0;
            this.tipus.Text = "Típus:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textGyart);
            this.panel2.Controls.Add(this.gyart);
            this.panel2.Location = new System.Drawing.Point(13, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 41);
            this.panel2.TabIndex = 3;
            // 
            // textGyart
            // 
            this.textGyart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textGyart.Location = new System.Drawing.Point(70, 5);
            this.textGyart.Name = "textGyart";
            this.textGyart.Size = new System.Drawing.Size(226, 23);
            this.textGyart.TabIndex = 1;
            // 
            // gyart
            // 
            this.gyart.AutoSize = true;
            this.gyart.Location = new System.Drawing.Point(4, 13);
            this.gyart.Name = "gyart";
            this.gyart.Size = new System.Drawing.Size(68, 15);
            this.gyart.TabIndex = 0;
            this.gyart.Text = "Gyártmány:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textRendsz);
            this.panel1.Controls.Add(this.rendsz);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 44);
            this.panel1.TabIndex = 2;
            // 
            // textRendsz
            // 
            this.textRendsz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textRendsz.Location = new System.Drawing.Point(71, 15);
            this.textRendsz.Name = "textRendsz";
            this.textRendsz.Size = new System.Drawing.Size(226, 23);
            this.textRendsz.TabIndex = 1;
            this.textRendsz.Text = "ABC123";
            this.textRendsz.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rendsz
            // 
            this.rendsz.AutoSize = true;
            this.rendsz.Location = new System.Drawing.Point(5, 23);
            this.rendsz.Name = "rendsz";
            this.rendsz.Size = new System.Drawing.Size(64, 15);
            this.rendsz.TabIndex = 0;
            this.rendsz.Text = "Rendszám:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox textRendsz;
        private System.Windows.Forms.Label rendsz;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioNem;
        private System.Windows.Forms.RadioButton radioIgen;
        private System.Windows.Forms.Label muszaki;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listSzin;
        private System.Windows.Forms.Label szin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textUzem;
        private System.Windows.Forms.Label uzem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textTips;
        private System.Windows.Forms.Label tipus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textGyart;
        private System.Windows.Forms.Label gyart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
    }
}

