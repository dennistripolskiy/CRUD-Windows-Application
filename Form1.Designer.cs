namespace CRUD_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.dateOfBirthTB = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearDataBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstNameTB
            // 
            this.firstNameTB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameTB.Location = new System.Drawing.Point(13, 43);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.PlaceholderText = "enter first name";
            this.firstNameTB.Size = new System.Drawing.Size(210, 25);
            this.firstNameTB.TabIndex = 2;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastNameTB.Location = new System.Drawing.Point(13, 74);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.PlaceholderText = "enter last name";
            this.lastNameTB.Size = new System.Drawing.Size(210, 25);
            this.lastNameTB.TabIndex = 3;
            // 
            // dateOfBirthTB
            // 
            this.dateOfBirthTB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthTB.Location = new System.Drawing.Point(13, 105);
            this.dateOfBirthTB.Name = "dateOfBirthTB";
            this.dateOfBirthTB.PlaceholderText = "enter date of birth";
            this.dateOfBirthTB.Size = new System.Drawing.Size(210, 25);
            this.dateOfBirthTB.TabIndex = 4;
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.Green;
            this.insertBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertBtn.Location = new System.Drawing.Point(13, 137);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(102, 41);
            this.insertBtn.TabIndex = 5;
            this.insertBtn.Text = "INSERT";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(121, 137);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(102, 41);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(12, 179);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(103, 41);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearDataBtn
            // 
            this.clearDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.clearDataBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearDataBtn.ForeColor = System.Drawing.Color.White;
            this.clearDataBtn.Location = new System.Drawing.Point(121, 179);
            this.clearDataBtn.Name = "clearDataBtn";
            this.clearDataBtn.Size = new System.Drawing.Size(102, 41);
            this.clearDataBtn.TabIndex = 8;
            this.clearDataBtn.Text = "CLEAR DATA";
            this.clearDataBtn.UseVisualStyleBackColor = false;
            this.clearDataBtn.Click += new System.EventHandler(this.clearDataBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(227, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 208);
            this.listBox1.TabIndex = 99;
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IdTB.Location = new System.Drawing.Point(13, 12);
            this.IdTB.Name = "IdTB";
            this.IdTB.PlaceholderText = "enter id";
            this.IdTB.Size = new System.Drawing.Size(210, 25);
            this.IdTB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(590, 229);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clearDataBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.dateOfBirthTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "CRUD Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox dateOfBirthTB;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button clearDataBtn;
        private ListBox listBox1;
        private TextBox IdTB;
    }
}