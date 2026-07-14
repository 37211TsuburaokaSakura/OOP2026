namespace CarReportSystem {
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
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            cbAuthor = new ComboBox();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            dgvRecords = new DataGridView();
            tbReport = new TextBox();
            label6 = new Label();
            btNewInput = new Button();
            label7 = new Label();
            btPicOpen = new Button();
            btDeletePicture = new Button();
            btAddRecord = new Button();
            btModifiRecord = new Button();
            btDeleteRecord = new Button();
            pdPicture = new PictureBox();
            menuStrip1 = new MenuStrip();
            ファイルAToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pdPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(110, 43);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(240, 39);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(25, 163);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(110, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 53);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Yu Gothic UI", 11.25F);
            rbOther.Location = new Point(340, 19);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(65, 24);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Font = new Font("Yu Gothic UI", 11.25F);
            rbImport.Location = new Point(262, 19);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(72, 24);
            rbImport.TabIndex = 0;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbSubaru.Location = new Point(194, 19);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(62, 24);
            rbSubaru.TabIndex = 0;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbHonda.Location = new Point(127, 19);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(62, 24);
            rbHonda.TabIndex = 0;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbNissan.Location = new Point(64, 19);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(57, 24);
            rbNissan.TabIndex = 0;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbToyota.Location = new Point(6, 18);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(62, 25);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(110, 101);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(412, 40);
            cbAuthor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(42, 216);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(110, 216);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(412, 40);
            cbCarName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(21, 280);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(110, 431);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.Size = new Size(768, 292);
            dgvRecords.TabIndex = 4;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(110, 280);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(412, 134);
            tbReport.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(42, 431);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // btNewInput
            // 
            btNewInput.BackColor = Color.White;
            btNewInput.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btNewInput.Location = new Point(369, 40);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(153, 41);
            btNewInput.TabIndex = 6;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(550, 43);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.BackColor = Color.White;
            btPicOpen.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btPicOpen.Location = new Point(627, 42);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(154, 38);
            btPicOpen.TabIndex = 6;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = false;
            // 
            // btDeletePicture
            // 
            btDeletePicture.BackColor = Color.FromArgb(255, 192, 192);
            btDeletePicture.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeletePicture.Location = new Point(787, 40);
            btDeletePicture.Name = "btDeletePicture";
            btDeletePicture.Size = new Size(91, 38);
            btDeletePicture.TabIndex = 6;
            btDeletePicture.Text = "削除";
            btDeletePicture.UseVisualStyleBackColor = false;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = Color.White;
            btAddRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddRecord.Location = new Point(559, 358);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(128, 56);
            btAddRecord.TabIndex = 6;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btModifiRecord
            // 
            btModifiRecord.BackColor = Color.White;
            btModifiRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifiRecord.Location = new Point(693, 358);
            btModifiRecord.Name = "btModifiRecord";
            btModifiRecord.Size = new Size(107, 56);
            btModifiRecord.TabIndex = 7;
            btModifiRecord.Text = "修正";
            btModifiRecord.UseVisualStyleBackColor = false;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.FromArgb(255, 192, 192);
            btDeleteRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteRecord.Location = new Point(806, 358);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(72, 56);
            btDeleteRecord.TabIndex = 8;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            // 
            // pdPicture
            // 
            pdPicture.BorderStyle = BorderStyle.FixedSingle;
            pdPicture.Location = new Point(550, 85);
            pdPicture.Name = "pdPicture";
            pdPicture.Size = new Size(328, 253);
            pdPicture.TabIndex = 9;
            pdPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルAToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(916, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルAToolStripMenuItem
            // 
            ファイルAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem });
            ファイルAToolStripMenuItem.Name = "ファイルAToolStripMenuItem";
            ファイルAToolStripMenuItem.Size = new Size(67, 20);
            ファイルAToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(162, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(162, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(159, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(162, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(159, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(162, 22);
            終了ToolStripMenuItem.Text = "終了（&x)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(73, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ（&H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(155, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslbMessage, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 721);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(916, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 743);
            Controls.Add(statusStrip1);
            Controls.Add(pdPicture);
            Controls.Add(btDeleteRecord);
            Controls.Add(btModifiRecord);
            Controls.Add(btDeletePicture);
            Controls.Add(btAddRecord);
            Controls.Add(btPicOpen);
            Controls.Add(btNewInput);
            Controls.Add(tbReport);
            Controls.Add(dgvRecords);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pdPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private ComboBox cbAuthor;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private DataGridView dgvRecords;
        private TextBox tbReport;
        private Label label6;
        private Button btNewInput;
        private Label label7;
        private Button btPicOpen;
        private Button btDeletePicture;
        private Button btAddRecord;
        private Button btModifiRecord;
        private Button btDeleteRecord;
        private PictureBox pdPicture;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルAToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslbMessage;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
