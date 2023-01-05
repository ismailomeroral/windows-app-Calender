namespace Calendar
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlPzt = new System.Windows.Forms.Panel();
            this.pnlSal = new System.Windows.Forms.Panel();
            this.pnlCar = new System.Windows.Forms.Panel();
            this.pnlPer = new System.Windows.Forms.Panel();
            this.pnlCum = new System.Windows.Forms.Panel();
            this.pnlCmt = new System.Windows.Forms.Panel();
            this.pnlPzr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmboxStartTime = new System.Windows.Forms.ComboBox();
            this.cmboxFinishTime = new System.Windows.Forms.ComboBox();
            this.cboxPzt = new System.Windows.Forms.CheckBox();
            this.pnldays = new System.Windows.Forms.Panel();
            this.cboxCmt = new System.Windows.Forms.CheckBox();
            this.cboxPzr = new System.Windows.Forms.CheckBox();
            this.cboxPer = new System.Windows.Forms.CheckBox();
            this.cboxCum = new System.Windows.Forms.CheckBox();
            this.cboxCar = new System.Windows.Forms.CheckBox();
            this.cboxSal = new System.Windows.Forms.CheckBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pctboxadd = new System.Windows.Forms.PictureBox();
            this.lblmytime = new System.Windows.Forms.Label();
            this.tmrmytime = new System.Windows.Forms.Timer(this.components);
            this.tmrAlarm = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Min = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnldays.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxadd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPzt
            // 
            this.pnlPzt.AutoScroll = true;
            this.pnlPzt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlPzt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPzt.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnlPzt.Location = new System.Drawing.Point(45, 72);
            this.pnlPzt.Name = "pnlPzt";
            this.pnlPzt.Size = new System.Drawing.Size(150, 300);
            this.pnlPzt.TabIndex = 0;
            // 
            // pnlSal
            // 
            this.pnlSal.AutoScroll = true;
            this.pnlSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSal.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnlSal.Location = new System.Drawing.Point(213, 72);
            this.pnlSal.Name = "pnlSal";
            this.pnlSal.Size = new System.Drawing.Size(150, 300);
            this.pnlSal.TabIndex = 0;
            // 
            // pnlCar
            // 
            this.pnlCar.AutoScroll = true;
            this.pnlCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCar.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnlCar.Location = new System.Drawing.Point(381, 72);
            this.pnlCar.Name = "pnlCar";
            this.pnlCar.Size = new System.Drawing.Size(150, 300);
            this.pnlCar.TabIndex = 0;
            // 
            // pnlPer
            // 
            this.pnlPer.AutoScroll = true;
            this.pnlPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPer.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnlPer.Location = new System.Drawing.Point(549, 72);
            this.pnlPer.Name = "pnlPer";
            this.pnlPer.Size = new System.Drawing.Size(150, 300);
            this.pnlPer.TabIndex = 0;
            // 
            // pnlCum
            // 
            this.pnlCum.AutoScroll = true;
            this.pnlCum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlCum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCum.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnlCum.Location = new System.Drawing.Point(717, 72);
            this.pnlCum.Name = "pnlCum";
            this.pnlCum.Size = new System.Drawing.Size(150, 300);
            this.pnlCum.TabIndex = 0;
            // 
            // pnlCmt
            // 
            this.pnlCmt.AutoScroll = true;
            this.pnlCmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlCmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCmt.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnlCmt.Location = new System.Drawing.Point(885, 72);
            this.pnlCmt.Name = "pnlCmt";
            this.pnlCmt.Size = new System.Drawing.Size(150, 300);
            this.pnlCmt.TabIndex = 0;
            // 
            // pnlPzr
            // 
            this.pnlPzr.AutoScroll = true;
            this.pnlPzr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlPzr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPzr.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnlPzr.Location = new System.Drawing.Point(1053, 72);
            this.pnlPzr.Name = "pnlPzr";
            this.pnlPzr.Size = new System.Drawing.Size(150, 300);
            this.pnlPzr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(47, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pazartesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(217, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(385, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Çarşamba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(553, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Perşembe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(721, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cuma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(889, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cumartesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(1057, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pazar";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Location = new System.Drawing.Point(996, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle\r\n";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtEventName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventName.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.txtEventName.ForeColor = System.Drawing.Color.Snow;
            this.txtEventName.Location = new System.Drawing.Point(17, 80);
            this.txtEventName.MaxLength = 21;
            this.txtEventName.Multiline = true;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(250, 31);
            this.txtEventName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(13, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Etkinlik Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(134, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "-";
            // 
            // cmboxStartTime
            // 
            this.cmboxStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cmboxStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboxStartTime.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cmboxStartTime.ForeColor = System.Drawing.Color.Snow;
            this.cmboxStartTime.FormatString = "t";
            this.cmboxStartTime.FormattingEnabled = true;
            this.cmboxStartTime.Location = new System.Drawing.Point(17, 128);
            this.cmboxStartTime.Name = "cmboxStartTime";
            this.cmboxStartTime.Size = new System.Drawing.Size(110, 28);
            this.cmboxStartTime.TabIndex = 4;
            this.cmboxStartTime.Text = "12:00";
            this.cmboxStartTime.SelectedIndexChanged += new System.EventHandler(this.cmboxStartTime_SelectedIndexChanged);
            // 
            // cmboxFinishTime
            // 
            this.cmboxFinishTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cmboxFinishTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboxFinishTime.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cmboxFinishTime.ForeColor = System.Drawing.Color.Snow;
            this.cmboxFinishTime.FormatString = "t";
            this.cmboxFinishTime.FormattingEnabled = true;
            this.cmboxFinishTime.Location = new System.Drawing.Point(159, 128);
            this.cmboxFinishTime.Name = "cmboxFinishTime";
            this.cmboxFinishTime.Size = new System.Drawing.Size(110, 28);
            this.cmboxFinishTime.TabIndex = 4;
            this.cmboxFinishTime.Text = "13:00";
            // 
            // cboxPzt
            // 
            this.cboxPzt.AutoSize = true;
            this.cboxPzt.Checked = true;
            this.cboxPzt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxPzt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxPzt.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cboxPzt.ForeColor = System.Drawing.Color.Snow;
            this.cboxPzt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxPzt.Location = new System.Drawing.Point(15, 17);
            this.cboxPzt.Name = "cboxPzt";
            this.cboxPzt.Size = new System.Drawing.Size(90, 24);
            this.cboxPzt.TabIndex = 5;
            this.cboxPzt.Text = "Pazartesi";
            this.cboxPzt.UseVisualStyleBackColor = true;
            // 
            // pnldays
            // 
            this.pnldays.AutoScroll = true;
            this.pnldays.AutoSize = true;
            this.pnldays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnldays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldays.Controls.Add(this.cboxCmt);
            this.pnldays.Controls.Add(this.cboxPzr);
            this.pnldays.Controls.Add(this.cboxPer);
            this.pnldays.Controls.Add(this.cboxCum);
            this.pnldays.Controls.Add(this.cboxCar);
            this.pnldays.Controls.Add(this.cboxSal);
            this.pnldays.Controls.Add(this.cboxPzt);
            this.pnldays.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.pnldays.Location = new System.Drawing.Point(620, 12);
            this.pnldays.Name = "pnldays";
            this.pnldays.Size = new System.Drawing.Size(329, 190);
            this.pnldays.TabIndex = 0;
            // 
            // cboxCmt
            // 
            this.cboxCmt.AutoSize = true;
            this.cboxCmt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxCmt.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cboxCmt.ForeColor = System.Drawing.Color.Snow;
            this.cboxCmt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxCmt.Location = new System.Drawing.Point(182, 60);
            this.cboxCmt.Name = "cboxCmt";
            this.cboxCmt.Size = new System.Drawing.Size(98, 24);
            this.cboxCmt.TabIndex = 5;
            this.cboxCmt.Text = "Cumartesi";
            this.cboxCmt.UseVisualStyleBackColor = true;
            // 
            // cboxPzr
            // 
            this.cboxPzr.AutoSize = true;
            this.cboxPzr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxPzr.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cboxPzr.ForeColor = System.Drawing.Color.Snow;
            this.cboxPzr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxPzr.Location = new System.Drawing.Point(182, 105);
            this.cboxPzr.Name = "cboxPzr";
            this.cboxPzr.Size = new System.Drawing.Size(66, 24);
            this.cboxPzr.TabIndex = 5;
            this.cboxPzr.Text = "Pazar";
            this.cboxPzr.UseVisualStyleBackColor = true;
            // 
            // cboxPer
            // 
            this.cboxPer.AutoSize = true;
            this.cboxPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxPer.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cboxPer.ForeColor = System.Drawing.Color.Snow;
            this.cboxPer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxPer.Location = new System.Drawing.Point(15, 150);
            this.cboxPer.Name = "cboxPer";
            this.cboxPer.Size = new System.Drawing.Size(97, 24);
            this.cboxPer.TabIndex = 5;
            this.cboxPer.Text = "Perşembe";
            this.cboxPer.UseVisualStyleBackColor = true;
            // 
            // cboxCum
            // 
            this.cboxCum.AutoSize = true;
            this.cboxCum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxCum.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cboxCum.ForeColor = System.Drawing.Color.Snow;
            this.cboxCum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxCum.Location = new System.Drawing.Point(182, 17);
            this.cboxCum.Name = "cboxCum";
            this.cboxCum.Size = new System.Drawing.Size(68, 24);
            this.cboxCum.TabIndex = 5;
            this.cboxCum.Text = "Cuma";
            this.cboxCum.UseVisualStyleBackColor = true;
            // 
            // cboxCar
            // 
            this.cboxCar.AutoSize = true;
            this.cboxCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxCar.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cboxCar.ForeColor = System.Drawing.Color.Snow;
            this.cboxCar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxCar.Location = new System.Drawing.Point(15, 105);
            this.cboxCar.Name = "cboxCar";
            this.cboxCar.Size = new System.Drawing.Size(97, 24);
            this.cboxCar.TabIndex = 5;
            this.cboxCar.Text = "Çarşamba";
            this.cboxCar.UseVisualStyleBackColor = true;
            // 
            // cboxSal
            // 
            this.cboxSal.AutoSize = true;
            this.cboxSal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxSal.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.cboxSal.ForeColor = System.Drawing.Color.Snow;
            this.cboxSal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboxSal.Location = new System.Drawing.Point(15, 60);
            this.cboxSal.Name = "cboxSal";
            this.cboxSal.Size = new System.Drawing.Size(52, 24);
            this.cboxSal.TabIndex = 5;
            this.cboxSal.Text = "Salı";
            this.cboxSal.UseVisualStyleBackColor = true;
            // 
            // txtExplanation
            // 
            this.txtExplanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplanation.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.txtExplanation.ForeColor = System.Drawing.Color.Snow;
            this.txtExplanation.Location = new System.Drawing.Point(317, 80);
            this.txtExplanation.MaxLength = 100;
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(250, 74);
            this.txtExplanation.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(327, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Açıklama";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmboxFinishTime);
            this.panel2.Controls.Add(this.pnldays);
            this.panel2.Controls.Add(this.cmboxStartTime);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtExplanation);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtEventName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.panel2.Location = new System.Drawing.Point(31, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 216);
            this.panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(996, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.Snow;
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(996, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pctboxadd
            // 
            this.pctboxadd.BackColor = System.Drawing.Color.Transparent;
            this.pctboxadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctboxadd.Image = global::Ajanda.Properties.Resources.Add_New;
            this.pctboxadd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctboxadd.Location = new System.Drawing.Point(600, 378);
            this.pctboxadd.Name = "pctboxadd";
            this.pctboxadd.Size = new System.Drawing.Size(50, 50);
            this.pctboxadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctboxadd.TabIndex = 2;
            this.pctboxadd.TabStop = false;
            this.pctboxadd.Click += new System.EventHandler(this.pctboxadd_Click);
            // 
            // lblmytime
            // 
            this.lblmytime.AutoSize = true;
            this.lblmytime.BackColor = System.Drawing.Color.Transparent;
            this.lblmytime.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.lblmytime.ForeColor = System.Drawing.Color.Snow;
            this.lblmytime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblmytime.Location = new System.Drawing.Point(46, 394);
            this.lblmytime.Name = "lblmytime";
            this.lblmytime.Size = new System.Drawing.Size(51, 22);
            this.lblmytime.TabIndex = 0;
            this.lblmytime.Text = "00:00";
            // 
            // tmrmytime
            // 
            this.tmrmytime.Interval = 30000;
            this.tmrmytime.Tick += new System.EventHandler(this.tmrmytime_Tick);
            // 
            // tmrAlarm
            // 
            this.tmrAlarm.Tick += new System.EventHandler(this.tmrAlarm_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Min);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 36);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.Font = new System.Drawing.Font("Verdana", 13.25F, System.Drawing.FontStyle.Bold);
            this.Min.ForeColor = System.Drawing.Color.MistyRose;
            this.Min.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Min.Location = new System.Drawing.Point(1204, 7);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(19, 22);
            this.Min.TabIndex = 5;
            this.Min.Text = "-";
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.IndianRed;
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.Location = new System.Drawing.Point(1235, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 18);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ajanda.Properties.Resources.Calendar_32;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1267, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctboxadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlPzr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblmytime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlCmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlCar);
            this.Controls.Add(this.pnlCum);
            this.Controls.Add(this.pnlSal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPzt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1267, 432);
            this.MinimumSize = new System.Drawing.Size(1267, 432);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajanda";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnldays.ResumeLayout(false);
            this.pnldays.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxadd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPzt;
        private System.Windows.Forms.Panel pnlSal;
        private System.Windows.Forms.Panel pnlCar;
        private System.Windows.Forms.Panel pnlPer;
        private System.Windows.Forms.Panel pnlCum;
        private System.Windows.Forms.Panel pnlCmt;
        private System.Windows.Forms.Panel pnlPzr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmboxStartTime;
        private System.Windows.Forms.ComboBox cmboxFinishTime;
        private System.Windows.Forms.CheckBox cboxPzt;
        private System.Windows.Forms.Panel pnldays;
        private System.Windows.Forms.CheckBox cboxCmt;
        private System.Windows.Forms.CheckBox cboxPzr;
        private System.Windows.Forms.CheckBox cboxPer;
        private System.Windows.Forms.CheckBox cboxCum;
        private System.Windows.Forms.CheckBox cboxCar;
        private System.Windows.Forms.CheckBox cboxSal;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pctboxadd;
        private System.Windows.Forms.Label lblmytime;
        private System.Windows.Forms.Timer tmrmytime;
        private System.Windows.Forms.Timer tmrAlarm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

