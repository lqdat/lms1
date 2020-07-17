using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace LB
{
    public partial class Trangchu : Form
    {
        Conect con = new Conect();
        String iD;
        
        public Trangchu(String id)
        {

            InitializeComponent();
            this.iD = id;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            load2();
            //DataGridViewCheckBoxColumn clm = new DataGridViewCheckBoxColumn();
            //clm.Name = "ckl";
            //clm.HeaderText = "Chon";
            //Dgv.Columns.Insert(3, clm);
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.Name = "btn";
            //btn.HeaderText = "Xem chi tiết";
            //btn.Text = "Xem";
            //btn.UseColumnTextForButtonValue = true;
            //Dgv.Columns.Insert(4, btn);

        }

        private void tkbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thongke tk = new Thongke();
            this.Hide();
            tk.ShowDialog();
            this.Show();
            load();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            add adds = new add();
            this.Hide();
            adds.ShowDialog();
            this.Show();
            load();
        }

        private void doimkbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Đoimk doimk = new Đoimk();
            this.Hide();
            doimk.ShowDialog();
            this.Show();
            load();
        }

        private void lSHDTTBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void dangxuatbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            chitiet a = new chitiet(id);
            this.Hide();
            a.ShowDialog();
            this.Show();
            load();

        }
        public void load()
        {
            Dgv.DataSource = con.getdata("select tentt,matt,tglv from thuthu");

        }
        public void load2()
        {
           DataTable d= con.getdata("select * from NQT where mQT = '" + iD + "' ");
            tenqttxt.Text = d.Rows[0][0].ToString();
            anh.Image = Image.FromFile(d.Rows[0][2].ToString());
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {

            int dem = 0;
            int kq = 0;
            for (int i = Dgv.Rows.Count - 1; i >= 0; i--)
            {
                if (Dgv.Rows[i].Cells[0].Value != null)
                {
                    dem = dem + 1;
                }
            }
            kq = dem;
            if (kq == 0)
            {
                MessageBox.Show("Bạn chưa chọn thông tin để xóa !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa những thông tin đã chọn này ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    for (int i = Dgv.Rows.Count - 1; i >= 0; i--)
                    {
                        if (Dgv.Rows[i].Cells[0].Value != null)
                        {
                            con.excute("Delete from thuthu where matt='" + Dgv.Rows[i].Cells[3].Value + "'");
                            load();
                        }
                    }
                    MessageBox.Show("Đã xóa thủ thư thành công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }



    } 
}
