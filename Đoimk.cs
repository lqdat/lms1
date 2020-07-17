using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB
{
    public partial class Đoimk : Form
    {
        public Đoimk()
        {
            InitializeComponent();
        }
        Conect cn = new Conect();
        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dmkbtn_Click(object sender, EventArgs e)
        {
            string qr = "SELECT* FROM NQT WHERE  mQT='" + txtmqt.Text + "'and mk = '" + txtmkcu.Text + "'";
            string sql = "UPDATE NQT SET mk=N '" + txtmkm.Text + "' WHERE nane=N'" + txtmqt.Text + "'";
            DataTable dt = cn.getdata(qr);
            if (txtmkcu.Text == "" || txtmkm.Text == "" || txtxn.Text == ""||txtmqt.Text == "") MessageBox.Show("Bạn chưa nhập đầy đủ");
                else if (txtmkm.Text != txtxn.Text) MessageBox.Show("Mật khẩu của bạn không trùng khớp");
                    else if (dt.Rows.Count > 0 )
                     {
                        cn.excute(sql);
                        MessageBox.Show("Đổi mật khẩu thành công");
                     }
                    else
                    {
                        
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }


        }
    }
}
