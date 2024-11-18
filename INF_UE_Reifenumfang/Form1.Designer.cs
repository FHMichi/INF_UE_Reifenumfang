namespace INF_UE_Reifenumfang
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
            tbWidth = new TextBox();
            label1 = new Label();
            cbThick = new ComboBox();
            label2 = new Label();
            cbSize = new ComboBox();
            lbSize = new Label();
            btCalc = new Button();
            label3 = new Label();
            lblResult = new Label();
            lblT1 = new Label();
            lblT3 = new Label();
            lblT2 = new Label();
            SuspendLayout();
            // 
            // tbWidth
            // 
            tbWidth.Location = new Point(86, 57);
            tbWidth.Name = "tbWidth";
            tbWidth.Size = new Size(219, 39);
            tbWidth.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 1;
            label1.Text = "Reifenbreite in mm";
            // 
            // cbThick
            // 
            cbThick.FormattingEnabled = true;
            cbThick.Location = new Point(347, 57);
            cbThick.Name = "cbThick";
            cbThick.Size = new Size(242, 40);
            cbThick.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 9);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 3;
            label2.Text = "Reifendicke in %";
            // 
            // cbSize
            // 
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(638, 56);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(242, 40);
            cbSize.TabIndex = 4;
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Location = new Point(648, 9);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(222, 32);
            lbSize.TabIndex = 5;
            lbSize.Text = "Felgendurchmesser";
            lbSize.TextAlign = ContentAlignment.TopRight;
            // 
            // btCalc
            // 
            btCalc.Location = new Point(918, 51);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(150, 46);
            btCalc.TabIndex = 6;
            btCalc.Text = "Calculate";
            btCalc.UseVisualStyleBackColor = true;
            btCalc.Click += btCalc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 220);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 7;
            label3.Text = "Result: ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(426, 220);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(25, 32);
            lblResult.TabIndex = 8;
            lblResult.Text = "?";
            // 
            // lblT1
            // 
            lblT1.AutoSize = true;
            lblT1.Location = new Point(141, 117);
            lblT1.Name = "lblT1";
            lblT1.Size = new Size(78, 32);
            lblT1.TabIndex = 9;
            lblT1.Text = "label4";
            // 
            // lblT3
            // 
            lblT3.AutoSize = true;
            lblT3.Location = new Point(717, 117);
            lblT3.Name = "lblT3";
            lblT3.Size = new Size(78, 32);
            lblT3.TabIndex = 10;
            lblT3.Text = "label5";
            // 
            // lblT2
            // 
            lblT2.AutoSize = true;
            lblT2.Location = new Point(426, 117);
            lblT2.Name = "lblT2";
            lblT2.Size = new Size(78, 32);
            lblT2.TabIndex = 11;
            lblT2.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 614);
            Controls.Add(lblT2);
            Controls.Add(lblT3);
            Controls.Add(lblT1);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(btCalc);
            Controls.Add(lbSize);
            Controls.Add(cbSize);
            Controls.Add(label2);
            Controls.Add(cbThick);
            Controls.Add(label1);
            Controls.Add(tbWidth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbWidth;
        private Label label1;
        private ComboBox cbThick;
        private Label label2;
        private ComboBox cbSize;
        private Label lbSize;
        private Button btCalc;
        private Label label3;
        private Label lblResult;
        private Label lblT1;
        private Label lblT3;
        private Label lblT2;
    }
}
