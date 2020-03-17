namespace GetADoctor
{
    partial class Form1
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
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.spec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor\' Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(182, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(241, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor\' s Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(182, 128);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(241, 20);
            this.age.TabIndex = 3;
            this.age.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // spec
            // 
            this.spec.Location = new System.Drawing.Point(182, 238);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(241, 20);
            this.spec.TabIndex = 7;
            this.spec.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Specialization";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // qual
            // 
            this.qual.Location = new System.Drawing.Point(182, 194);
            this.qual.Name = "qual";
            this.qual.Size = new System.Drawing.Size(241, 20);
            this.qual.TabIndex = 5;
            this.qual.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qualification";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doctors Registration Form";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(182, 343);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(241, 20);
            this.add.TabIndex = 12;
            this.add.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(182, 309);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(241, 20);
            this.phone.TabIndex = 10;
            this.phone.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(212, 386);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(101, 35);
            this.register.TabIndex = 13;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(182, 88);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(241, 20);
            this.sex.TabIndex = 15;
            this.sex.TextChanged += new System.EventHandler(this.sex_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sex";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(182, 164);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(241, 20);
            this.exp.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Years of Experience";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(182, 273);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(241, 20);
            this.mail.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 180);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(817, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.register);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox spec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

