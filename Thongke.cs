using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB
{
    public partial class Thongke : Form
    {

        
        public Thongke()
        {
            InitializeComponent();
        }
        Conect con = new Conect();



        private void Thongke_Load(object sender, EventArgs e)
        {
            
        }
        public void load1()
        {
            
            dgv.DataSource = con.getdata("Select * from LSHDTT");
        }
        public void s1()
        {

        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ////if (cbsearch.Text == "matt")
            ////{
            ////    dgv.DataSource = con.getdata("Select * from LSHDTT where matt like'%" + txtsearch.Text.Trim() + "%'");
            ////}
            ////else if (cbsearch.Text == "tentt")
            ////{
            ////    dgv.DataSource = con.getdata("Select * from LSHDTT where tentt like'%" + txtsearch.Text.Trim() + "%'");
            ////}
            ////else if (cbsearch.Text == "hd")
            ////{
            ////    dgv.DataSource = con.getdata("Select * from LSHDTT where hd like'%" + txtsearch.Text.Trim() + "%'");
            ////}
            ////else if (cbsearch.Text == "chitiet")
            ////{
            ////    dgv.DataSource = con.getdata("Select * from LSHDTT where chitiet like'%" + txtsearch.Text.Trim() + "%'");
            ////}
            ////else if (cbsearch.Text == "Tg")
            ////{
            ////    dgv.DataSource = con.getdata("Select * from thuvien.dbo.LSHDTT where tg like'%" + txtsearch.Text.Trim() + "%'");
            ////}
            ////else if (cbsearch.Text == "")
            ////{
            ////    dgv.DataSource = con.getdata("Select * from thuvien.dbo.LSHDTT where matt like'%" + txtsearch.Text.Trim() + "%' or tentt like'%" + txtsearch.Text.Trim() + "%' or hd like'%" + txtsearch.Text.Trim() + "%' or chitiet like'%" + txtsearch.Text.Trim() + "%' or tg like'%" + txtsearch.Text.Trim() + "%' ");
            ////}
            refesh();
            DataTable ta = con.getdata("select * from LSHDTT");
            if (cbsearch.Text != null)
                foreach (DataRow row in ta.Rows)
                {
                    String cmt = row[checkcb()].ToString();
                    string bx = txtsearch.Text;
                    if (cmt.Contains(bx))
                    {
                        add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());

                    }
                }
            else
                load1();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bm, new Rectangle(0, 0, dgv.Width, dgv.Height));
            e.Graphics.DrawImage(bm, 0, 200);
        }
        private void txtsearch_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }
        public int checkcb()
        {
            if(cbsearch.Text == "Thời gian")
            {
                return 0;
            }
            else if(cbsearch.Text =="Mã thủ thư")
            {
                return 1;
            }
            else if(cbsearch.Text =="Tên thủ thư")
            {
                return 2;
            }
            else if(cbsearch.Text =="Hoạt động")
            {
                return 3;
            }
            else 
            {
                return 4;
            }
        }
        public void add(string a,String b,String c,String d,String e)
        {
            DataGridViewRow row = (DataGridViewRow)dgv.Rows[0].Clone();
            row.Cells[0].Value = a;
            row.Cells[1].Value = b;
            row.Cells[2].Value = c;
            row.Cells[3].Value = d;
            row.Cells[4].Value = e;
            dgv.Rows.Add(row);
        }
        public void refesh()
        {
            if(dgv.RowCount >1)
            for(int i = 0;i<dgv.RowCount-1;i++)
            {
                dgv.Rows.Clear();
            }
        }
    }
}
