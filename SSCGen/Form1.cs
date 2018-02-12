using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSCGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_gen_Click(object sender, EventArgs e)
        {
            string tc = "";

            if (cB_tc.Checked)
            {
                tc = "[IMG]http://www.elitepvpers.com/images/tbm/trading/tick.png[/IMG]";
            }

            rtB_code.Text = @"[URL=""" + tB_store.Text + "\"" + "][IMG]" + tB_img.Text + "[/IMG][/URL] | " + tB_op.Text +" | [CENTER]" + tB_eg.Text + " [IMG]http://www.elitepvpers.com/images/tbm/gold.gif[/IMG][/CENTER] | " + tc + "| [URL=\"" + tB_treasure.Text + "\"][IMG]http://www.elitepvpers.com/images/tbm/treasures.gif[/IMG][/URL]";
        }

        private void bt_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtB_code.Text);
        }
    }
}
