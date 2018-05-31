using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace QLNS.QLQuatrinhCongTac
{
    public partial class frmupdate : Form
    {
        QuaTrinhCongTacBUL QTCTBUL = new QuaTrinhCongTacBUL();
        QuaTrinhCongTac QTCT = new QuaTrinhCongTac();
        public frmupdate(QuaTrinhCongTac QTCTDTO)
        {
            InitializeComponent();
            QTCT = QTCTDTO;
        }
      
        private void frmupdate_Load(object sender, EventArgs e)
        {

            if (QTCT != null)
            {
                txtMaNV.Text = QTCT.MaNV;
                dtpDenNgay.Value = QTCT.DenNgay;
                dtpTuNgay.Value = QTCT.TuNgay;
                txtNoiCongTac.Text = QTCT.NoiCongTac.ToString();
                txtChucVu.Text = QTCT.ChucVu.ToString();
            }
            else
            {
                MessageBox.Show("ma hoac tu ngay khong dung");
            }
        }
      
        private void btnsearch_Click(object sender, EventArgs e)
        {
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
           
            if (txtMaNV.Text != "")
            {
                if (txtNoiCongTac.Text != "")
                {
                    if (txtChucVu.Text != "")
                    {
                        if (dtpTuNgay.Value < dtpDenNgay.Value)
                        {
                            QTCT = QTCTBUL.searchMaAndDayBUL(txtMaNV.Text, dtpTuNgay.Value);
                            if (QTCT != null)
                            {

                             
                                    QTCTBUL.updateBUL(txtMaNV.Text, dtpTuNgay.Value, dtpDenNgay.Value, txtNoiCongTac.Text,
                                        txtChucVu.Text);
                           
                            }
                            else
                            {
                                MessageBox.Show("ma hoac tu ngay khong dung");
                            }

                        }
                        else
                        {
                            lblthongbao.Text = "đến ngày phải lớn hơn từ ngày";
                        }
                    }
                    else
                    {
                        lblthongbao.Text = "chức vụ không được để trống";
                    }
                }
                else
                {
                    lblthongbao.Text = "nơi công tác không được để trống";
                }
            }
            else
            {
                lblthongbao.Text = "mã không được để trống";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
