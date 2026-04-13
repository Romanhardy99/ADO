namespace Academy
{
    partial class StudentForm
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
            this.cbStudentGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbStudentGroup
            // 
            this.cbStudentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStudentGroup.FormattingEnabled = true;
            this.cbStudentGroup.Location = new System.Drawing.Point(190, 261);
            this.cbStudentGroup.Name = "cbStudentGroup";
            this.cbStudentGroup.Size = new System.Drawing.Size(246, 33);
            this.cbStudentGroup.TabIndex = 18;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.BackColor = System.Drawing.Color.Transparent;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(91, 261);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(89, 25);
            this.labelGroup.TabIndex = 20;
            this.labelGroup.Text = "Группа:";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 417);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.cbStudentGroup);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Controls.SetChildIndex(this.cbStudentGroup, 0);
            this.Controls.SetChildIndex(this.labelGroup, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudentGroup;
        private System.Windows.Forms.Label labelGroup;
    }
}