using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Form2.cs;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form fm2 = new Form2();
            fm2.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form2_Load(sender, e);
            Form fm5 = new Form5();
            //fm5.MdiParent = this;
            fm5.Show();

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form m1 = new MDIParent1();
            m1.Show();
        }

        private void 资产对比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm3 = new Form3();
            fm3.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm7 = new Form7();
            fm7.Show();
        }

        private void 仓库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm4 = new Form4();
            fm4.Show();
        }

        private void 仓库修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm6 = new Form6();
            fm6.Show();
        }

        private void 仓库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form m1 = new MDIParent1();
            m1.Show();
        }
    }
}
