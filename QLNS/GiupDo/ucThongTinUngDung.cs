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
    public partial class ucThongTinUngDung : UserControl
    {
        public ucThongTinUngDung()
        {
            InitializeComponent();
        }

        private void ucThongTinUngDung_Load(object sender, EventArgs e)
        {
            txtGioiThieu.Text = "\t\t\t\t Quản Lí Nhân Sự  \r\n" +
    "Ngày nay, cùng với sự bùng nổ của số lượng các công ty thì việc quản lí nhân sự là yêu cầu cấp thiết\r\n" +
          "của các cơ quan và doanh nghiệp Nhằm đáp ứng nhu cầu đó, CTSN.inc cho ra đời sản phẩm QLNS là chương \t\n" +
         " trình quản lý nhân sự với chức năng phong phú, giao diện thân thiện và linh hoạt, mức bảo mật cao \r\n" +
         " là công cụ đắc lực cho các nhà quản lý hành chính - sự nghiệp. \r\n" +
           "\r\n" +
         " Phạm vi ứng dụng: Áp dụng cho các đơn vị doanh nghiệp, các cơ quan nhà nước và cơ quan Công quyền. \r\n" +
          "Với các mô hình khác nhau: Công ty, Tập đoàn, Tổng công ty và các cơ quan tổ chức các cấp(Từ địa phương đến Trung ương)." +
          "Tính năng nổi bật (thân thiện, linh hoạt):" +

 "- Thân thiện, dễ sử dụng: Thông tin nhân sự được nạp theo nhóm dạng các tab như[Thành phần cơ bản],[Thông tin cơ bản], [Quá trình đào tạo], [Quá trình công tác], ….Gần gũi, thân thiện cho phép người sử dụng thao tác trên phần mềm một cách rễ dàng, nhanh chóng theo thói quen quản lý hồ sơ thủ công.\r\n\r\n" +

"-  Tính động linh hoạt: Quản lý các phòng ban theo mô hình phân cấp cây, cho phép người dùng thêm bớt chủ động các phòng ban theo ý muốn. Thuận lợi khi có sự thay đổi nhân sự trong cơ quan, cũng như khi có sự thuyên chuyển nhân sự.\r\n\r\n" +


"- Tính bảo mật cao: Tùy theo mức độ phân quyền với người dùng mới thao tác được các tác vụ tương ứng. Ví dụ, nếu là người quản trị mới có thể thêm bớt, chỉnh sửa hồ sơ nhân viên, còn nếu là người dùng, chỉ được xem và xuất in báo cáo. Hệ thống có khả năng Lưu vết thông tin người dùng, khi có người dùng\r\n\r\n" +
"Chức năng phong phúc bao gồm \r\n" +
"- Quản Lí hồ sơ \r\n" +
"- Quản Lí Trình độ chuyên môn \r\n" +
"- Quản Lí trình độ ngoại ngữ \r\n" +
"- Quản Lí quá trình công tác \r\n" +
"- Quản Lí nhân viên chức vụ \r\n" +
"- quản Lí phòng ban \r\n" +
"\r\n" +
"Hệ thống báo cáo phong phúc và chi tiết gồm: \r\n" +
"- Báo cáo hồ sơ nhân viên\r\n" +
"- Báo cáo thông kê trình độ chuyên môn \r\n" +
"- báo cáo thống kê trình độ ngoại ngữ";












        }

        private void txtGioiThieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
