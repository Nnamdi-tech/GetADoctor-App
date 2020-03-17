namespace GetADoctor
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.ComboID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AppointdatePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ComboPatientName = new System.Windows.Forms.ComboBox();
            this.ComboDoctorName = new System.Windows.Forms.ComboBox();
            this.AppointmentGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Appointment Here";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Patient\'s Name";
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(208, 305);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(101, 35);
            this.register.TabIndex = 46;
            this.register.Text = "Submit";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // ComboID
            // 
            this.ComboID.Location = new System.Drawing.Point(162, 70);
            this.ComboID.Name = "ComboID";
            this.ComboID.Size = new System.Drawing.Size(241, 20);
            this.ComboID.TabIndex = 45;
            this.ComboID.TextChanged += new System.EventHandler(this.gnt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Doctor\'s Name";
            // 
            // AppointdatePicker
            // 
            this.AppointdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppointdatePicker.Location = new System.Drawing.Point(162, 178);
            this.AppointdatePicker.Name = "AppointdatePicker";
            this.AppointdatePicker.Size = new System.Drawing.Size(241, 20);
            this.AppointdatePicker.TabIndex = 51;
            // 
            // AppointmentTimePicker
            // 
            this.AppointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.AppointmentTimePicker.Location = new System.Drawing.Point(162, 217);
            this.AppointmentTimePicker.Name = "AppointmentTimePicker";
            this.AppointmentTimePicker.Size = new System.Drawing.Size(241, 20);
            this.AppointmentTimePicker.TabIndex = 52;
            this.AppointmentTimePicker.Value = new System.DateTime(2020, 1, 23, 0, 0, 0, 0);
            // 
            // ComboPatientName
            // 
            this.ComboPatientName.FormattingEnabled = true;
            this.ComboPatientName.Location = new System.Drawing.Point(162, 130);
            this.ComboPatientName.Name = "ComboPatientName";
            this.ComboPatientName.Size = new System.Drawing.Size(241, 21);
            this.ComboPatientName.TabIndex = 53;
            this.ComboPatientName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ComboDoctorName
            // 
            this.ComboDoctorName.FormattingEnabled = true;
            this.ComboDoctorName.Location = new System.Drawing.Point(162, 103);
            this.ComboDoctorName.Name = "ComboDoctorName";
            this.ComboDoctorName.Size = new System.Drawing.Size(241, 21);
            this.ComboDoctorName.TabIndex = 54;
            this.ComboDoctorName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AppointmentGridView
            // 
            this.AppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGridView.Location = new System.Drawing.Point(505, 70);
            this.AppointmentGridView.Name = "AppointmentGridView";
            this.AppointmentGridView.Size = new System.Drawing.Size(283, 270);
            this.AppointmentGridView.TabIndex = 55;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppointmentGridView);
            this.Controls.Add(this.ComboDoctorName);
            this.Controls.Add(this.ComboPatientName);
            this.Controls.Add(this.AppointmentTimePicker);
            this.Controls.Add(this.AppointdatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.register);
            this.Controls.Add(this.ComboID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox ComboID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker AppointdatePicker;
        private System.Windows.Forms.DateTimePicker AppointmentTimePicker;
        private System.Windows.Forms.ComboBox ComboPatientName;
        private System.Windows.Forms.ComboBox ComboDoctorName;
        private System.Windows.Forms.DataGridView AppointmentGridView;
    }
}