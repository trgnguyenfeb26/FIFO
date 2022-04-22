using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO_N19DCCN124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] khungTrang = new int[1000];
        public int[] chuoiTrang = new int[1000];
        public int soKhungTrang, n, dem = 0;
        public int[,] ketQua = new int[100, 1000];
        public char[] loiTrang = new char[1000];
        public bool tiepTuc;
        //Hàm khởi tạo đặt lại biến đếm số trang lỗi (dem) = 0
        //đặt lại màn hình và thanh thông báo
        void khoitao()
        {
            dem = 0;
            tb_Screen.ResetText();
            tb_ThongBao.ResetText();
           
        }

        //Hàm thuật toán FIFO
        void FIFO()
        {
            int i, j, k, kiemTra;
            //khởi tạo giá trị ban đầu cho mảng khungTrang là -1;
            for (i = 0; i < soKhungTrang; i++) khungTrang[i] = -1;
            //Biến j là biến thứ tự gán vào của khungTrang (ban đầu j=0) 
            j = 0;
            //Duyệt từ đầu đến cuối của chuỗi trang nhập vào
            for (i = 1; i <= n; i++){
                kiemTra = 0;
                //Duyệt xem có khungTrang nào trùng với phần tử chuoiTrang hiện tại
                for (k = 0; k < soKhungTrang; k++) 
                    //Nếu trùng thì gán biến kiemTra = 1 để làm dấu
                    if (khungTrang[k] == chuoiTrang[i]) kiemTra = 1;
                //Nếu biến kiemTra == 0 tức là chuoiTrang hiện tại không trùng 
                //với phần tử nào của khungTrang
                if (kiemTra == 0){
                    //Cập nhật khungTrang thứ j bằng chuoiTrang hiện tại
                    khungTrang[j] = chuoiTrang[i];
                    //Đồng thời cập nhật loiTrang hiện tại = '*'
                    loiTrang[i] = '*';
                    //Vì j chỉ chạy từ 0 đến soKhungTrang - 1
                    //Nên chỉ lấy phần dư của (j + 1) / soKhungTrang
                    j = (j + 1) % soKhungTrang;
                    //Tăng biến đếm (dem) lỗi trang lên 1
                    dem++;
                    //Gán sokhungTrang hiện tại vào mảng hai chiều ketQua
                    for (k = 0; k < soKhungTrang; k++) 
                        ketQua[k, i] = khungTrang[k];
                }
                //Ngược lại là chuoiTrang hiện tại trùng với
                //tất cả phần từ trong khungTrang
                else
                {
                    //Cập nhận loiTrang hiện tại bằng trống (' ')
                    loiTrang[i] = ' ';
                    //Cập nhật soKhungTrang trước đó vào ketQua
                    for (k = 0; k < soKhungTrang; k++)
                        ketQua[k, i] = khungTrang[k];
                }

            }
        }
       
        //Hàm kiểm tra Text có phải là chuỗi số hay không?
        bool KiemTraSo(string Text)
        {
            //Nếu chuỗi Text rỗng thì chuỗi không phải là chuỗi số
            if (Text == "") return false;
            //Duyệt từng phần tử trong Text 
            foreach (Char c in Text)
            {
                //Nếu có 1 phần từ không phải là số thì Text không phải là chuỗi số
                if (!Char.IsDigit(c))
                    return false;
            }
            //Nếu tất cả phần tử là số thì Text là chuỗi số
            return true;
        }
        //Hàm kiểm tra ChuoiTrang có phải là mảng số cách nhau bởi ' '
        //ví dụ "3 4 6 2 3 4 5 6 6" ->true
        bool KiemTraChuoiTrang(string pText)
        {
            //Nếu chuỗi pText rỗng thì chuỗi không phải là chuỗi số
            if (pText == "") return false;
            //Duyệt từng phần tử trong pText 
            foreach (Char c in pText)
            {
                //Nếu có 1 phần từ không phải là số và khác ' '
                //thì pText không phải là chuỗi số
                if (!Char.IsDigit(c) && c != ' ')
                    return false;
            }
            return true;
        }
        //Hàm đọc dữ liệu từ người dùng nhập
        void DocDuLieu()
        { 
            //Khai báo mảng chuỗi tam 
            string[] tam = null;
            //Gán từ phần tử của mảng chuỗi tạm bằng
            //những số được tách từ chuỗi trang với dấu hiệu để tách là ' '
            //Ví dụ: "3 4 5 6 4" sẽ được tách thành "3","4","5","6","4" 
            tam = new Regex(" ").Split(at_Chuoitrang.Text);
            //Kiểu tra xem người dùng có nhập đúng dữ kiệu hay không
            if (KiemTraSo(at_Sotrang.Text)==false || KiemTraSo(at_Sokhungtrang.Text)==false || KiemTraChuoiTrang(at_Chuoitrang.Text)==false)
            {
                //Nếu không thì thông báo lỗi
                MessageBox.Show("Chưa nhập dữ liệu hoặc nhập dữ liệu sai!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Cập nhật biến tiepTuc = false 
                tiepTuc = false;
            }
            //Nếu người dùng nhập đúng
            else
            {
                //Cập nhật biến tiepTuc = true
                tiepTuc = true;
                //Gán n bằng số trang mà người dùng nhập vào
                n = int.Parse(at_Sotrang.Text.ToString());
                //Gán soKhungTrang bằng số khung trang mà người dùng nhập vào
                soKhungTrang = int.Parse(at_Sokhungtrang.Text);
                //Gán tất cả phần tử trong mảng chuỗi tam vào mảng chuoiTrang
                for (int i = 1; i <= n; i++)
                    //int.Parse dùng để ép kiểu chuỗi thành kiểu số nguyên
                    chuoiTrang[i] = int.Parse(tam[i - 1]);
                
            }
        }
        //Hàm thực hiện thuật toán FIFO và hiển thị dữ liệu ra màn hình 
        void ThucHien()
        {
            //Gọi hàm FIFO() để chạy thuật toán FIFO
            FIFO();
            //Cập nhật màn hình thành rỗng
            tb_Screen.Text = "";
            //Duyệt mảng hai chiều ketQua 
            //Chỉ số i chạy từ 0 đến số khung trang - 1
            //Chỉ số j chạy từ 1 đến n (số trang)
            for (int i = 0; i < soKhungTrang; i++){
                for (int j = 1; j <= n; j++)
                    //Nếu giá trị của ketQua hiện tại khác -1
                    if (ketQua[i, j] != -1)
                        //Thì hiển thị ra màn hình kết quả hiện tại
                        //"\t" là tab để dễ dàng phân biệt các phần tử
                        tb_Screen.Text += ketQua[i, j].ToString() + "\t";
                    //Ngược lại nếu ketQua hiện tại bằng -1
                    else
                        //Hiển thị ra màn hình tab (trống)
                        tb_Screen.Text += "\t";
                //tạo một dòng mới (khung trang thứ i+1)
                tb_Screen.Text += Environment.NewLine;
            }
            //Duyệt mảng loiTrang
            for (int i = 1; i <= n; i++)
                //Hiển thị ra màn hình dấu * nếu trang lỗi, rỗng (' ') nếu ngược lại
                tb_Screen.Text += loiTrang[i].ToString() + "\t";
            //Hiển thị tổng số trang lỗi
            tb_ThongBao.Text += "Số trang lỗi là: ";
            tb_ThongBao.Text += dem.ToString();
        }
        //Sự kiện nút Chạy chương trình
        private void btn_Run_Click(object sender, EventArgs e)
        {
            //Khởi tạo và đọc dự liệu từ người dùng
            khoitao();
            DocDuLieu();
            //Nếu người dùng nhập dữ liệu đúng thì biến tiepTuc = true 
            if (tiepTuc == true)
            {
                //Chạy hàm ThucHien() 
                ThucHien();
            }
            //Ngược lại người dùng nhập dữ liệu lỗi thì biến tiepTuc = false
            else
                //Chạy hàm Reset()
                Reset();
        }
        //Hàm khởi tạo và đặt lại tất cả các giá trị về ban đầu
        void Reset()
        {
            //Chạy hàm khởi tạo
            khoitao();
            //Đặt lại tất cả các hiển thi, edittext trên màn hình
            tb_Screen.ResetText();
            tb_ThongBao.ResetText();
            at_Sotrang.ResetText();
            at_Sokhungtrang.ResetText();
            at_Chuoitrang.ResetText();
        }
        //Sự kiện nút Đặt lại
        private void btn_Reset_Click(object sender, EventArgs e)
        {   
            //Chạy hàm Reset()
            Reset();
        }
        private void tb_Tieude_TextChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void at_Sokhungtrang_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_ThongBao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        } 
    }
}
