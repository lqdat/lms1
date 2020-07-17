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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        Conect con = new Conect();
        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void btnbr_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Title = "Chọn Ảnh";
            _openFileDialog.InitialDirectory = @"C:\Users\USER\Pictures";//Thư mục mặc định khi mở
            _openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";// Lọc ra những file cần hiển thị
            _openFileDialog.FilterIndex = 1;//chúng ta có All files là 1,exe là 2 
            _openFileDialog.RestoreDirectory = true;
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtanh.Text = _openFileDialog.FileName;//đường dẫn của file trong textbox
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String sql = "Insert into thuthu(matt,tentt,ns,qq,choOHT,cmnd,anh,matkhau,tglv,sdt,email,gt) values('"+taoma()+"','" + txtten.Text + "','" + txtns.Text + "','" + txtqq.Text + "','" + txtadr.Text + "','" + txtcmnd.Text + "','" + txtanh.Text + "','" + taoma() + "','0','"+txtsdt.Text+ "','" + txtemail.Text + "','" + gioitinh()+ "')";
            
            if (con.excute(sql))
            {
                MessageBox.Show("Đã thêm thủ thư thành công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Đã thêm thủ thư thất bại !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
        public string taoma()
        {
           DataTable dt = con.getdata("select COUNT(*) from thuthu");
            string x = "TT" + dt.Rows[0][0].ToString();
            return x;
        }

        public string gioitinh()
        {
            string x = "";
            if (cknam.Checked == true || cknu.Checked == true)
            {
                if (cknam.Checked == true)
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
    }
}
