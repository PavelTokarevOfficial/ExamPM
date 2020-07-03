namespace ExamPM
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAccounting = new System.Windows.Forms.Button();
            this.buttonPharmacy = new System.Windows.Forms.Button();
            this.buttonMedicine = new System.Windows.Forms.Button();
            this.buttonExid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAccounting
            // 
            this.buttonAccounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAccounting.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccounting.Location = new System.Drawing.Point(62, 109);
            this.buttonAccounting.Name = "buttonAccounting";
            this.buttonAccounting.Size = new System.Drawing.Size(100, 36);
            this.buttonAccounting.TabIndex = 1;
            this.buttonAccounting.Text = "Наличие";
            this.buttonAccounting.UseVisualStyleBackColor = false;
            this.buttonAccounting.Click += new System.EventHandler(this.buttonAccounting_Click);
            // 
            // buttonPharmacy
            // 
            this.buttonPharmacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonPharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPharmacy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPharmacy.Location = new System.Drawing.Point(62, 163);
            this.buttonPharmacy.Name = "buttonPharmacy";
            this.buttonPharmacy.Size = new System.Drawing.Size(100, 36);
            this.buttonPharmacy.TabIndex = 2;
            this.buttonPharmacy.Text = "Аптека";
            this.buttonPharmacy.UseVisualStyleBackColor = false;
            this.buttonPharmacy.Click += new System.EventHandler(this.buttonPharmacy_Click);
            // 
            // buttonMedicine
            // 
            this.buttonMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMedicine.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMedicine.Location = new System.Drawing.Point(62, 217);
            this.buttonMedicine.Name = "buttonMedicine";
            this.buttonMedicine.Size = new System.Drawing.Size(100, 36);
            this.buttonMedicine.TabIndex = 3;
            this.buttonMedicine.Text = "Лекарство";
            this.buttonMedicine.UseVisualStyleBackColor = false;
            this.buttonMedicine.Click += new System.EventHandler(this.buttonMedicine_Click);
            // 
            // buttonExid
            // 
            this.buttonExid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonExid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExid.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExid.Location = new System.Drawing.Point(62, 271);
            this.buttonExid.Name = "buttonExid";
            this.buttonExid.Size = new System.Drawing.Size(100, 36);
            this.buttonExid.TabIndex = 4;
            this.buttonExid.Text = "Закрыть программу";
            this.buttonExid.UseVisualStyleBackColor = false;
            this.buttonExid.Click += new System.EventHandler(this.buttonExid_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(227, 330);
            this.Controls.Add(this.buttonExid);
            this.Controls.Add(this.buttonMedicine);
            this.Controls.Add(this.buttonPharmacy);
            this.Controls.Add(this.buttonAccounting);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAccounting;
        private System.Windows.Forms.Button buttonPharmacy;
        private System.Windows.Forms.Button buttonMedicine;
        private System.Windows.Forms.Button buttonExid;
    }
}

