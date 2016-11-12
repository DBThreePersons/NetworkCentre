using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            
            string str = "Server=192.168.2.114;User ID=test;Password=test;Database=world;CharSet=gbk";
            MySqlConnection con = new MySqlConnection(str);//实例化链接    con.Open();//开启连接    string strcmd = "select * from runoob_tbl";    MySqlCommand cmd = new MySqlCommand(strcmd, con);    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);    DataSet ds = new DataSet();    ada.Fill(ds);//查询结果填充数据集    dataGridView1.DataSource = ds.Tables[0];    con.Close();//关闭连接}
            con.Open();
            string strcmd = "select * from city where ID < 10";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel=true;
        }
    }
}
