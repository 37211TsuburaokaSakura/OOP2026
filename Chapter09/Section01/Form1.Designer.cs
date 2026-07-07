namespace Section01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dtpdate = new DateTimePicker();
            dtpGet = new Button();
            tbOut = new TextBox();
            nudDay = new NumericUpDown();
            label1 = new Label();
            dtpBirth = new DateTimePicker();
            btBirthCalc = new Button();
            label2 = new Label();
            tbOut2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // dtpdate
            // 
            dtpdate.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpdate.Location = new Point(12, 12);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(287, 46);
            dtpdate.TabIndex = 0;
            // 
            // dtpGet
            // 
            dtpGet.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpGet.Location = new Point(305, 12);
            dtpGet.Name = "dtpGet";
            dtpGet.Size = new Size(105, 46);
            dtpGet.TabIndex = 1;
            dtpGet.Text = "計算";
            dtpGet.UseVisualStyleBackColor = true;
            dtpGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(12, 197);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(398, 39);
            tbOut.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(12, 73);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 39);
            nudDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(138, 81);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpBirth
            // 
            dtpBirth.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirth.Location = new Point(12, 145);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(287, 46);
            dtpBirth.TabIndex = 0;
            // 
            // btBirthCalc
            // 
            btBirthCalc.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btBirthCalc.Location = new Point(305, 145);
            btBirthCalc.Name = "btBirthCalc";
            btBirthCalc.Size = new Size(105, 46);
            btBirthCalc.TabIndex = 5;
            btBirthCalc.Text = "計算";
            btBirthCalc.UseVisualStyleBackColor = true;
            btBirthCalc.Click += btBirthCalc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "生年月日";
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(12, 242);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(398, 39);
            tbOut2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 333);
            Controls.Add(label2);
            Controls.Add(btBirthCalc);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut2);
            Controls.Add(tbOut);
            Controls.Add(dtpGet);
            Controls.Add(dtpBirth);
            Controls.Add(dtpdate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpdate;
        private Button dtpGet;
        private TextBox tbOut;
        private NumericUpDown nudDay;
        private Label label1;
        private DateTimePicker dtpBirth;
        private Button btBirthCalc;
        private Label label2;
        private TextBox tbOut2;
    }
}
