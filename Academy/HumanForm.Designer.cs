namespace Academy
{
    partial class HumanForm
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
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labePhone = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLastName.Location = new System.Drawing.Point(74, 18);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(110, 25);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFirstName.Location = new System.Drawing.Point(125, 58);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(59, 25);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMiddleName.Location = new System.Drawing.Point(73, 98);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(111, 25);
            this.labelMiddleName.TabIndex = 2;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBirthDate.Location = new System.Drawing.Point(12, 138);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(172, 25);
            this.labelBirthDate.TabIndex = 3;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmail.Location = new System.Drawing.Point(106, 182);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(78, 25);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-mail:";
            // 
            // labePhone
            // 
            this.labePhone.AutoSize = true;
            this.labePhone.BackColor = System.Drawing.Color.Transparent;
            this.labePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labePhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labePhone.Location = new System.Drawing.Point(76, 218);
            this.labePhone.Name = "labePhone";
            this.labePhone.Size = new System.Drawing.Size(108, 25);
            this.labePhone.TabIndex = 6;
            this.labePhone.Text = "Телефон:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(190, 15);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(246, 31);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(190, 55);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(246, 31);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(190, 95);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(246, 31);
            this.textBoxMiddleName.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(190, 179);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(246, 31);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(190, 215);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(246, 31);
            this.textBoxPhone.TabIndex = 11;
            // 
            // dateTimePickerDateBirth
            // 
            this.dateTimePickerDateBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateBirth.CustomFormat = "yyyy.MMMM.dd";
            this.dateTimePickerDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateBirth.Location = new System.Drawing.Point(190, 135);
            this.dateTimePickerDateBirth.Name = "dateTimePickerDateBirth";
            this.dateTimePickerDateBirth.Size = new System.Drawing.Size(246, 31);
            this.dateTimePickerDateBirth.TabIndex = 12;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(442, 15);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(237, 233);
            this.pictureBoxPhoto.TabIndex = 13;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.Transparent;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBrowse.Location = new System.Drawing.Point(520, 254);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(89, 45);
            this.buttonBrowse.TabIndex = 14;
            this.buttonBrowse.Text = "Обзор";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Transparent;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(442, 342);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(115, 36);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(566, 342);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 36);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(12, 354);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 25);
            this.labelID.TabIndex = 17;
            // 
            // HumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Academy.Properties.Resources.stud;
            this.ClientSize = new System.Drawing.Size(692, 420);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.dateTimePickerDateBirth);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labePhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HumanForm";
            this.Text = "HumanForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labePhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBirth;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelID;
    }
}