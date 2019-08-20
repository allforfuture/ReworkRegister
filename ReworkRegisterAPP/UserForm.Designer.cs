namespace ReworkRegisterAPP
{
    partial class UserForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Modify_btn = new System.Windows.Forms.Button();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sel_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sel_btn);
            this.groupBox2.Controls.Add(this.Modify_btn);
            this.groupBox2.Controls.Add(this.pw_txt);
            this.groupBox2.Controls.Add(this.id_txt);
            this.groupBox2.Controls.Add(this.Submit_btn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(40, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 265);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户信息";
            // 
            // Modify_btn
            // 
            this.Modify_btn.Location = new System.Drawing.Point(154, 146);
            this.Modify_btn.Name = "Modify_btn";
            this.Modify_btn.Size = new System.Drawing.Size(75, 25);
            this.Modify_btn.TabIndex = 5;
            this.Modify_btn.Text = "修改";
            this.Modify_btn.UseVisualStyleBackColor = true;
            this.Modify_btn.Click += new System.EventHandler(this.Modify_btn_Click);
            // 
            // pw_txt
            // 
            this.pw_txt.Location = new System.Drawing.Point(79, 84);
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.Size = new System.Drawing.Size(121, 21);
            this.pw_txt.TabIndex = 4;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(79, 46);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(120, 21);
            this.id_txt.TabIndex = 3;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(46, 145);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(64, 26);
            this.Submit_btn.TabIndex = 2;
            this.Submit_btn.Text = "添加";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // Sel_btn
            // 
            this.Sel_btn.Location = new System.Drawing.Point(215, 46);
            this.Sel_btn.Name = "Sel_btn";
            this.Sel_btn.Size = new System.Drawing.Size(45, 24);
            this.Sel_btn.TabIndex = 6;
            this.Sel_btn.Text = "查询";
            this.Sel_btn.UseVisualStyleBackColor = true;
            this.Sel_btn.Click += new System.EventHandler(this.Sel_btn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 394);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Sel_btn;
        private System.Windows.Forms.Button Modify_btn;
        private System.Windows.Forms.TextBox pw_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}