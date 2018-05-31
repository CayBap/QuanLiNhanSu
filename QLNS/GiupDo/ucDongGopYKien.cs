using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNS.GiupDo
{
    public partial class ucDongGopYKien : UserControl
    {
        public ucDongGopYKien()
        {
            InitializeComponent();
        }

        private void ucDongGopYKien_Load(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContent.Clear();
            MessageBox.Show("Cám ơn những đóng góp ý kiến của bạn, chúng tôi sẽ phản hồi đến bạn sớm nhất có thể. Xin cảm ơn!", "Gửi Thành Công!");
        }
    }
}
