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
    public partial class Form4 : Form
    {
        //string str = "Server=192.168.2.114;User ID=test;Password=test;Database=world;CharSet=gbk";
        MySqlConnection mysqlcon = new MySqlConnection("Server=127.0.0.1;User ID=test;Password=12345678;Database=wlzx;CharSet=gbk");

        public Form4()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox3.Enabled = false;
            this.textBox4.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(Control ctr in groupBox1.Controls)
            {
                if(ctr is CheckBox&& ((CheckBox)ctr).CheckState == CheckState.Checked)
                {
                    i++;
                }
            }
            if(i==0)
            {
                MessageBox.Show("请至少选择一个查询条件");
                return;
            }
           
            try
            {
                mysqlcon.Open();
                string sbid;
                string sbname;
                string sbposition;
                string sbdate;
                string strcmd = "select * from wlzx_ckzb where ";

                bool tag = false;
                if (checkBox1.CheckState==CheckState.Checked)
                {
                    sbid = " ID = \'" + textBox1.Text + "\'";
                    strcmd += sbid;
                    tag = true;
                }
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    if (tag)
                    {
                        sbname = " and NAME = \'" + textBox2.Text + "\'";
                    }
                    else
                    {
                        sbname = " NAME = \'" + textBox2.Text + "\'";
                    }
                    strcmd += sbname;
                    tag = true;
                }
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    if (tag)
                    {
                        sbposition = " and POSITION = \'" + textBox3.Text+ "\'";
                    }
                    else
                    {
                        sbposition = " POSITION = \'" + textBox3.Text + "\'";
                    }
                    strcmd += sbposition;
                    tag = true;
                }
                if (checkBox4.CheckState == CheckState.Checked)
                {
                    if (tag )
                    {
                        sbdate = " and DATE = " + textBox4.Text;
                    }
                    else
                    {
                        sbdate = " DATE = " + textBox4.Text;
                    }
                    strcmd += sbdate;
                    tag = true;
                }

               
                MySqlCommand cmd = new MySqlCommand(strcmd, mysqlcon);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds, "table1");
                dataGridView1.DataSource = ds.Tables["table1"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mysqlcon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                mysqlcon.Open();
                string strcmd = "select * from wlzx_ckzb";
                MySqlCommand cmd = new MySqlCommand(strcmd, mysqlcon);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds, "table1");
                dataGridView1.DataSource = ds.Tables["table1"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mysqlcon.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                //textBox1.Text=""
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }
    }
}
