using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            Translater();
        }

        public void Translater()
        {
            try
            {
                string fr = txtFr.Text;
                var fr_en = new PhapAnhProxy.PhapAnhService();
                var en_vn = new AnhVietProxy.AnhVietService();

                string vn = "not found !";
                vn = en_vn.GetMean(fr_en.GetMean(fr));
                txtVn.Text = vn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ Liệu từ điển không tồn tại !");
                
            }

        }
    }
}
