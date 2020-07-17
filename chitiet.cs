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
    public partial class chitiet : Form
    {
        string id;
        Conect cn = new Conect();
        public chitiet(string id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void Btupdate_Click(object sender, EventArgs e)
        {
            string kq = "Update thuthu Set anh ='" + txtanh.Text + "',tentt ='" + txtten.Text + "',gt='" + gioitinh() + "',matkhau ='" + txtmk.Text + "',ns ='" + txtns.Text + "',qq ='" + txtqq.Text + "',choOHT ='" + txtadr.Text + "',cmnd ='" + txtcmnd.Text + "',sdt='" + txtsdt.Text + "',email ='" + txtemail.Text + "' where matt ='" + lbmatt.Text + "'";
            //cn.excute(kq);
            if (cn.excute(kq))
            {
                MessageBox.Show("Đã sua thủ thư thành công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã sua thủ thư that bai !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            

        }

        private void chitiet_Load(object sender, EventArgs e)
        {
            load();
            
        }
        public void load()
        {
            DataTable dt = cn.getdata("select * from thuthu where matt ='" + id + "'");
            lbmatt.Text = dt.Rows[0][0].ToString();
            txtanh.Text = dt.Rows[0][1].ToString();
            txtten.Text = dt.Rows[0][2].ToString();
            Checkbox();
            txtmk.Text = dt.Rows[0][4].ToString();
            txtns.Text = dt.Rows[0][5].ToString();
            txtqq.Text = dt.Rows[0][6].ToString();
            txtadr.Text = dt.Rows[0][7].ToString();
            txtcmnd.Text = dt.Rows[0][8].ToString();
            tglv.Text = dt.Rows[0][9].ToString();
            txtsdt.Text = dt.Rows[0][10].ToString();
            txtemail.Text = dt.Rows[0][11].ToString();
            anh.Image = Image.FromFile(dt.Rows[0][1].ToString());


        }
        public string gioitinh()
        {
            string x = "";
            if (ckna.Checked == true || cknu.Checked == true)
            {
                if (ckna.Checked == true)
                {
                    x = "nam";
                }
                else if (cknu.Checked == true)
                {
                    x = "nữ";
                }
                else
                    x = "khác";
            };
            return x;
        }
        public void Checkbox()
            {
            DataTable dt = cn.getdata("select * from thuthu where matt ='" + id + "'");
            if(dt.Rows[0][3].ToString() == "nam")
            {
                ckna.Checked = true;
            }
            else
            {
                cknu.Checked = true;
            }
            }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
