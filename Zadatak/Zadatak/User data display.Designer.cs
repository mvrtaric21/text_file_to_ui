namespace Zadatak
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChoosefile = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtYearofbirth = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtRoleattribute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Faculty: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "[role specific attribute]";
            // 
            // btnChoosefile
            // 
            this.btnChoosefile.Location = new System.Drawing.Point(268, 344);
            this.btnChoosefile.Name = "btnChoosefile";
            this.btnChoosefile.Size = new System.Drawing.Size(155, 56);
            this.btnChoosefile.TabIndex = 6;
            this.btnChoosefile.Text = "Choose file...";
            this.btnChoosefile.UseVisualStyleBackColor = true;
            this.btnChoosefile.Click += new System.EventHandler(this.btnChoosefile_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(177, 38);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(186, 22);
            this.txtFullname.TabIndex = 7;
            this.txtFullname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtYearofbirth
            // 
            this.txtYearofbirth.Location = new System.Drawing.Point(177, 82);
            this.txtYearofbirth.Name = "txtYearofbirth";
            this.txtYearofbirth.Size = new System.Drawing.Size(185, 22);
            this.txtYearofbirth.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(177, 134);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(183, 22);
            this.txtCity.TabIndex = 9;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(177, 182);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(182, 22);
            this.txtFaculty.TabIndex = 10;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(177, 234);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(181, 22);
            this.txtRole.TabIndex = 11;
            // 
            // txtRoleattribute
            // 
            this.txtRoleattribute.Location = new System.Drawing.Point(177, 278);
            this.txtRoleattribute.Name = "txtRoleattribute";
            this.txtRoleattribute.Size = new System.Drawing.Size(180, 22);
            this.txtRoleattribute.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 421);
            this.Controls.Add(this.txtRoleattribute);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtYearofbirth);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.btnChoosefile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "User data display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChoosefile;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtYearofbirth;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtRoleattribute;
    }
}

