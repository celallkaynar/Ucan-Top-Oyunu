namespace ucanTopOyunu
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
            components = new System.ComponentModel.Container();
            labelUst = new Label();
            labelSol = new Label();
            labelSag = new Label();
            labelCan = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Top = new Button();
            Biz = new Button();
            SuspendLayout();
            // 
            // labelUst
            // 
            labelUst.BackColor = SystemColors.ActiveCaptionText;
            labelUst.Location = new Point(12, 22);
            labelUst.Name = "labelUst";
            labelUst.Size = new Size(698, 13);
            labelUst.TabIndex = 0;
            labelUst.Text = "label1";
            // 
            // labelSol
            // 
            labelSol.BackColor = SystemColors.ActiveCaptionText;
            labelSol.Location = new Point(12, 35);
            labelSol.Name = "labelSol";
            labelSol.Size = new Size(13, 447);
            labelSol.TabIndex = 1;
            labelSol.Text = "label2";
            // 
            // labelSag
            // 
            labelSag.BackColor = SystemColors.ActiveCaptionText;
            labelSag.Location = new Point(697, 35);
            labelSag.Name = "labelSag";
            labelSag.Size = new Size(13, 447);
            labelSag.TabIndex = 2;
            labelSag.Text = "label3";
            // 
            // labelCan
            // 
            labelCan.AutoSize = true;
            labelCan.Location = new Point(797, 65);
            labelCan.Name = "labelCan";
            labelCan.Size = new Size(17, 20);
            labelCan.TabIndex = 5;
            labelCan.Text = "3";
            // 
            // label5
            // 
            label5.BackColor = Color.Red;
            label5.Location = new Point(763, 71);
            label5.Name = "label5";
            label5.Size = new Size(14, 14);
            label5.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Top
            // 
            Top.BackColor = Color.Red;
            Top.Location = new Point(206, 185);
            Top.Name = "Top";
            Top.Size = new Size(18, 18);
            Top.TabIndex = 8;
            Top.UseVisualStyleBackColor = false;
            // 
            // Biz
            // 
            Biz.BackColor = Color.FromArgb(255, 128, 0);
            Biz.Location = new Point(288, 464);
            Biz.Name = "Biz";
            Biz.Size = new Size(74, 18);
            Biz.TabIndex = 9;
            Biz.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 524);
            Controls.Add(Biz);
            Controls.Add(Top);
            Controls.Add(label5);
            Controls.Add(labelCan);
            Controls.Add(labelSag);
            Controls.Add(labelSol);
            Controls.Add(labelUst);
            Name = "Form1";
            Text = "Uçan Top Oyunu";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUst;
        private Label labelSol;
        private Label labelSag;
        private Label labelCan;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Button Top;
        private Button Biz;
    }
}