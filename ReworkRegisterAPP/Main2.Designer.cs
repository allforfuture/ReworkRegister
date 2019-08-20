namespace ReworkRegisterAPP
{
    partial class Main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.label1 = new System.Windows.Forms.Label();
            this.barcode_txt = new System.Windows.Forms.TextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.line_cbx = new System.Windows.Forms.ComboBox();
            this.process_cbx = new System.Windows.Forms.ComboBox();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Output_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processDetail_cbx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbx_time = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbx_date = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbx_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barErr_lbl = new System.Windows.Forms.Label();
            this.ftp_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serialsDGV = new System.Windows.Forms.DataGridView();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.error_msg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialsDGV)).BeginInit();
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
            this.barcode_txt.Location = new System.Drawing.Point(54, 115);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(284, 26);
            this.barcode_txt.TabIndex = 1;
            this.barcode_txt.ClientSizeChanged += new System.EventHandler(this.sn_change);
            this.barcode_txt.TextChanged += new System.EventHandler(this.sn_change);
            this.barcode_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_txt_KeyDown);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.PeachPuff;
            this.Register_btn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_btn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Register_btn.Location = new System.Drawing.Point(554, 187);
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
            this.line_cbx.Location = new System.Drawing.Point(80, 17);
            this.line_cbx.Name = "line_cbx";
            this.line_cbx.Size = new System.Drawing.Size(121, 24);
            this.line_cbx.TabIndex = 4;
            // 
            // process_cbx
            // 
            this.process_cbx.BackColor = System.Drawing.Color.PeachPuff;
            this.process_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.process_cbx.Enabled = false;
            this.process_cbx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.process_cbx.FormattingEnabled = true;
            this.process_cbx.Location = new System.Drawing.Point(217, 46);
            this.process_cbx.Name = "process_cbx";
            this.process_cbx.Size = new System.Drawing.Size(121, 24);
            this.process_cbx.TabIndex = 5;
            this.process_cbx.SelectedIndexChanged += new System.EventHandler(this.process_cbx_SelectedIndexChanged);
            // 
            // user_txt
            // 
            this.user_txt.BackColor = System.Drawing.Color.PeachPuff;
            this.user_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.user_txt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_txt.Location = new System.Drawing.Point(54, 65);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(284, 26);
            this.user_txt.TabIndex = 8;
            this.user_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_txt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(27, 68);
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
            this.label3.Location = new System.Drawing.Point(25, 118);
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
            this.groupBox1.Controls.Add(this.processDetail_cbx);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbx_time);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbx_date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbx_type);
            this.groupBox1.Controls.Add(this.line_cbx);
            this.groupBox1.Controls.Add(this.process_cbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.SpringGreen;
            this.groupBox1.Location = new System.Drawing.Point(359, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // processDetail_cbx
            // 
            this.processDetail_cbx.BackColor = System.Drawing.Color.PeachPuff;
            this.processDetail_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processDetail_cbx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processDetail_cbx.FormattingEnabled = true;
            this.processDetail_cbx.Location = new System.Drawing.Point(80, 45);
            this.processDetail_cbx.Name = "processDetail_cbx";
            this.processDetail_cbx.Size = new System.Drawing.Size(121, 24);
            this.processDetail_cbx.TabIndex = 26;
            this.processDetail_cbx.SelectedIndexChanged += new System.EventHandler(this.processDetail_cbx_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.SpringGreen;
            this.label10.Location = new System.Drawing.Point(214, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "时间：";
            // 
            // cmbx_time
            // 
            this.cmbx_time.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbx_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbx_time.FormattingEnabled = true;
            this.cmbx_time.Location = new System.Drawing.Point(270, 106);
            this.cmbx_time.Name = "cmbx_time";
            this.cmbx_time.Size = new System.Drawing.Size(110, 24);
            this.cmbx_time.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.SpringGreen;
            this.label9.Location = new System.Drawing.Point(24, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "日期：";
            // 
            // cmbx_date
            // 
            this.cmbx_date.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbx_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_date.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbx_date.FormattingEnabled = true;
            this.cmbx_date.Location = new System.Drawing.Point(82, 105);
            this.cmbx_date.Name = "cmbx_date";
            this.cmbx_date.Size = new System.Drawing.Size(119, 24);
            this.cmbx_date.TabIndex = 22;
            this.cmbx_date.SelectedIndexChanged += new System.EventHandler(this.dateChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.SpringGreen;
            this.label8.Location = new System.Drawing.Point(8, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "SN位数：";
            // 
            // cmbx_type
            // 
            this.cmbx_type.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbx_type.FormattingEnabled = true;
            this.cmbx_type.Location = new System.Drawing.Point(81, 75);
            this.cmbx_type.Name = "cmbx_type";
            this.cmbx_type.Size = new System.Drawing.Size(121, 24);
            this.cmbx_type.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.SpringGreen;
            this.label5.Location = new System.Drawing.Point(34, 20);
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
            this.label6.Location = new System.Drawing.Point(10, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Process：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(251, 198);
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
            this.ftp_lbl.Location = new System.Drawing.Point(143, 146);
            this.ftp_lbl.Name = "ftp_lbl";
            this.ftp_lbl.Size = new System.Drawing.Size(0, 20);
            this.ftp_lbl.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SpringGreen;
            this.label7.Location = new System.Drawing.Point(16, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "SN List";
            // 
            // serialsDGV
            // 
            this.serialsDGV.AllowUserToAddRows = false;
            this.serialsDGV.AllowUserToDeleteRows = false;
            this.serialsDGV.BackgroundColor = System.Drawing.Color.LightCyan;
            this.serialsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serialsDGV.ColumnHeadersVisible = false;
            this.serialsDGV.Location = new System.Drawing.Point(12, 216);
            this.serialsDGV.Name = "serialsDGV";
            this.serialsDGV.RowHeadersVisible = false;
            this.serialsDGV.RowTemplate.Height = 23;
            this.serialsDGV.Size = new System.Drawing.Size(234, 345);
            this.serialsDGV.TabIndex = 17;
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qtyLbl.ForeColor = System.Drawing.Color.SpringGreen;
            this.qtyLbl.Location = new System.Drawing.Point(78, 194);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(0, 16);
            this.qtyLbl.TabIndex = 18;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.clearBtn.Location = new System.Drawing.Point(147, 193);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(83, 23);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "清除(Clear)";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.ForeColor = System.Drawing.SystemColors.Control;
            this.error_msg.Location = new System.Drawing.Point(52, 158);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(41, 12);
            this.error_msg.TabIndex = 20;
            this.error_msg.Text = "label9";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(252, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 345);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(331, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "上传(Upload)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.uploadBtn_click);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(759, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.serialsDGV);
            this.Controls.Add(this.label7);
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
            this.MaximizeBox = false;
            this.Name = "Main2";
            this.Text = "COSM";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Main_Resize);
            this.MaximumSizeChanged += new System.EventHandler(this.Main_Resize);
            this.ResizeEnd += new System.EventHandler(this.Main_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcode_txt;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.ComboBox line_cbx;
        private System.Windows.Forms.ComboBox process_cbx;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView serialsDGV;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbx_type;
        private System.Windows.Forms.Label error_msg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbx_time;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbx_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox processDetail_cbx;
    }
}

