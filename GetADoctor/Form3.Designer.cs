namespace GetADoctor
{
    partial class Form3
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
            this.PatientView = new System.Windows.Forms.DataGridView();
            this.mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientView)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientView
            // 
            this.PatientView.AllowUserToOrderColumns = true;
            this.PatientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientView.Location = new System.Drawing.Point(389, 19);
            this.PatientView.Name = "PatientView";
            this.PatientView.Size = new System.Drawing.Size(386, 180);
            this.PatientView.TabIndex = 42;
            this.PatientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(142, 237);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(241, 20);
            this.mail.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Email";
            // 
            // bg
            // 
            this.bg.Location = new System.Drawing.Point(142, 174);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(241, 20);
            this.bg.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Blood Group";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(142, 98);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(241, 20);
            this.sex.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Sex";
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(183, 354);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(101, 35);
            this.register.TabIndex = 35;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(142, 307);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(241, 20);
            this.add.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Address";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(142, 273);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(241, 20);
            this.phone.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Patients Registration Form";
            // 
            // gnt
            // 
            this.gnt.Location = new System.Drawing.Point(142, 204);
            this.gnt.Name = "gnt";
            this.gnt.Size = new System.Drawing.Size(241, 20);
            this.gnt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Genotype";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(142, 138);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(241, 20);
            this.age.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Patient\' s Age";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(142, 63);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(241, 20);
            this.name.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Patient\'s Name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PatientView);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.register);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PatientView;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
    }
}