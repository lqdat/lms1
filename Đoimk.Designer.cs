namespace LB
{
    partial class Đoimk
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
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.huybtn = new System.Windows.Forms.Button();
            this.dmkbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmqt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(178, 61);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(159, 22);
            this.txtmkcu.TabIndex = 0;
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(178, 103);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(159, 22);
            this.txtmkm.TabIndex = 1;
            // 
            // huybtn
            // 
            this.huybtn.Location = new System.Drawing.Point(84, 207);
            this.huybtn.Name = "huybtn";
            this.huybtn.Size = new System.Drawing.Size(75, 37);
            this.huybtn.TabIndex = 2;
            this.huybtn.Text = "Hủy";
            this.huybtn.UseVisualStyleBackColor = true;
            this.huybtn.Click += new System.EventHandler(this.huybtn_Click);
            // 
            // dmkbtn
            // 
            this.dmkbtn.Location = new System.Drawing.Point(221, 207);
            this.dmkbtn.Name = "dmkbtn";
            this.dmkbtn.Size = new System.Drawing.Size(116, 37);
            this.dmkbtn.TabIndex = 3;
            this.dmkbtn.Text = "Đổi mật khẩu";
            this.dmkbtn.UseVisualStyleBackColor = true;
            this.dmkbtn.Click += new System.EventHandler(this.dmkbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "xác nhận mật khẩu";
            // 
            // txtxn
            // 
            this.txtxn.Location = new System.Drawing.Point(178, 138);
            this.txtxn.Name = "txtxn";
            this.txtxn.Size = new System.Drawing.Size(159, 22);
            this.txtxn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã quản trị";
            // 
            // txtmqt
            // 
            this.txtmqt.Location = new System.Drawing.Point(178, 23);
            this.txtmqt.Name = "txtmqt";
            this.txtmqt.Size = new System.Drawing.Size(159, 22);
            this.txtmqt.TabIndex = 9;
            // 
            // Đoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 289);
            this.Controls.Add(this.txtmqt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtxn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dmkbtn);
            this.Controls.Add(this.huybtn);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.txtmkcu);
            this.Name = "Đoimk";
            this.Text = "Đoimk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.Button huybtn;
        private System.Windows.Forms.Button dmkbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmqt;
    }
}