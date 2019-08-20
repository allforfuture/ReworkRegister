namespace ReworkRegisterAPP
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.barcode_txt = new System.Windows.Forms.TextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.line_cbx = new System.Windows.Forms.ComboBox();
            this.process_cbx = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Output_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barErr_lbl = new System.Windows.Forms.Label();
            this.ftp_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COSM";
            // 
            // barcode_txt
            // 
            this.barcode_txt.BackColor = System.Drawing.Color.PeachPuff;
            this.barcode_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.barcode_txt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barcode_txt.Location = new System.Drawing.Point(54, 88);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(416, 26);
            this.barcode_txt.TabIndex = 1;
            this.barcode_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_txt_KeyDown);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.Register_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_btn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Register_btn.Location = new System.Drawing.Point(18, 138);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(75, 29);
            this.Register_btn.TabIndex = 3;
            this.Register_btn.Text = "Regist";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Visible = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // line_cbx
            // 
            this.line_cbx.BackColor = System.Drawing.Color.PeachPuff;
            this.line_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.line_cbx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.line_cbx.FormattingEnabled = true;
            this.line_cbx.Location = new System.Drawing.Point(72, 22);
            this.line_cbx.Name = "line_cbx";
            this.line_cbx.Size = new System.Drawing.Size(121, 24);
            this.line_cbx.TabIndex = 4;
            // 
            // process_cbx
            // 
            this.process_cbx.BackColor = System.Drawing.Color.PeachPuff;
            this.process_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.process_cbx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.process_cbx.FormattingEnabled = true;
            this.process_cbx.Location = new System.Drawing.Point(72, 63);
            this.process_cbx.Name = "process_cbx";
            this.process_cbx.Size = new System.Drawing.Size(121, 24);
            this.process_cbx.TabIndex = 5;
            this.process_cbx.SelectedIndexChanged += new System.EventHandler(this.process_cbx_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(14, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 285);
            this.panel1.TabIndex = 7;
            // 
            // user_txt
            // 
            this.user_txt.BackColor = System.Drawing.Color.PeachPuff;
            this.user_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.user_txt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_txt.Location = new System.Drawing.Point(54, 47);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(416, 26);
            this.user_txt.TabIndex = 8;
            this.user_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SN：";
            // 
            // Output_lbl
            // 
            this.Output_lbl.AutoSize = true;
            this.Output_lbl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_lbl.ForeColor = System.Drawing.Color.Lime;
            this.Output_lbl.Location = new System.Drawing.Point(143, 142);
            this.Output_lbl.Name = "Output_lbl";
            this.Output_lbl.Size = new System.Drawing.Size(0, 20);
            this.Output_lbl.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.line_cbx);
            this.groupBox1.Controls.Add(this.process_cbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(633, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 102);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Line：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Process：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "NG Reason";
            // 
            // barErr_lbl
            // 
            this.barErr_lbl.AutoSize = true;
            this.barErr_lbl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barErr_lbl.ForeColor = System.Drawing.Color.Red;
            this.barErr_lbl.Location = new System.Drawing.Point(478, 95);
            this.barErr_lbl.Name = "barErr_lbl";
            this.barErr_lbl.Size = new System.Drawing.Size(0, 14);
            this.barErr_lbl.TabIndex = 14;
            // 
            // ftp_lbl
            // 
            this.ftp_lbl.AutoSize = true;
            this.ftp_lbl.BackColor = System.Drawing.SystemColors.ControlText;
            this.ftp_lbl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ftp_lbl.ForeColor = System.Drawing.Color.Red;
            this.ftp_lbl.Location = new System.Drawing.Point(153, 462);
            this.ftp_lbl.Name = "ftp_lbl";
            this.ftp_lbl.Size = new System.Drawing.Size(0, 20);
            this.ftp_lbl.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(899, 513);
            this.Controls.Add(this.ftp_lbl);
            this.Controls.Add(this.barErr_lbl);
            this.Controls.Add(this.barcode_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Output_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "COSM";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Main_Resize);
            this.MaximumSizeChanged += new System.EventHandler(this.Main_Resize);
            this.ResizeEnd += new System.EventHandler(this.Main_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcode_txt;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.ComboBox line_cbx;
        private System.Windows.Forms.ComboBox process_cbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Output_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label barErr_lbl;
        private System.Windows.Forms.Label ftp_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

