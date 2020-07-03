namespace ExamPM
{
    partial class FormMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicine));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listViewMedecine = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 18);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Название";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(12, 133);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(106, 18);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Форма выпуска";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDosage.Location = new System.Drawing.Point(12, 183);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(77, 18);
            this.labelDosage.TabIndex = 5;
            this.labelDosage.Text = "Дозировка";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(12, 233);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(107, 18);
            this.labelManufacturer.TabIndex = 6;
            this.labelManufacturer.Text = "Производитель";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(12, 283);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(38, 18);
            this.labelData.TabIndex = 7;
            this.labelData.Text = "Дата";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(15, 104);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 26);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.textBoxDosage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDosage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDosage.Location = new System.Drawing.Point(15, 204);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(121, 26);
            this.textBoxDosage.TabIndex = 9;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.textBoxManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxManufacturer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxManufacturer.Location = new System.Drawing.Point(15, 254);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(121, 26);
            this.textBoxManufacturer.TabIndex = 10;
            // 
            // textBoxData
            // 
            this.textBoxData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.textBoxData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxData.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxData.Location = new System.Drawing.Point(15, 304);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(121, 26);
            this.textBoxData.TabIndex = 11;
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxType.Location = new System.Drawing.Point(15, 154);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 26);
            this.comboBoxType.TabIndex = 12;
            // 
            // listViewMedecine
            // 
            this.listViewMedecine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.listViewMedecine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMedecine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMedecine.FullRowSelect = true;
            this.listViewMedecine.GridLines = true;
            this.listViewMedecine.HideSelection = false;
            this.listViewMedecine.Location = new System.Drawing.Point(142, 12);
            this.listViewMedecine.MultiSelect = false;
            this.listViewMedecine.Name = "listViewMedecine";
            this.listViewMedecine.Size = new System.Drawing.Size(541, 486);
            this.listViewMedecine.TabIndex = 13;
            this.listViewMedecine.UseCompatibleStateImageBehavior = false;
            this.listViewMedecine.View = System.Windows.Forms.View.Details;
            this.listViewMedecine.SelectedIndexChanged += new System.EventHandler(this.listViewMedecine_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Форма выпуска";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дозировка";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Производитель";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(19, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 36);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(19, 378);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 36);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(19, 420);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 36);
            this.buttonDel.TabIndex = 16;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.Location = new System.Drawing.Point(19, 462);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(100, 36);
            this.buttonMenu.TabIndex = 17;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // FormMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(699, 510);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewMedecine);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лекарства";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListView listViewMedecine;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}