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
            btGet = new Button();
            tbOut = new TextBox();
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
            // btGet
            // 
            btGet.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGet.Location = new Point(305, 12);
            btGet.Name = "btGet";
            btGet.Size = new Size(105, 46);
            btGet.TabIndex = 1;
            btGet.Text = "取得";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(12, 95);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(398, 39);
            tbOut.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 506);
            Controls.Add(tbOut);
            Controls.Add(btGet);
            Controls.Add(dtpdate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpdate;
        private Button btGet;
        private TextBox tbOut;
    }
}
