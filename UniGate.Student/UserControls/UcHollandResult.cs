using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UniGate.Shared.DTOs;

namespace UniGate.Student.UserControls
{
    public partial class UcHollandResult : UserControl
    {
        private HollandResultDto _data;

        // 1. Constructor nhận DTO từ bài test (Dùng cái này để hiện kết quả vừa làm)
        public UcHollandResult(HollandResultDto dto)
        {
            InitializeComponent();
            _data = dto;
            this.Load += UcHollandResult_Load;
        }

        // 2. Constructor mặc định (Để không lỗi Designer)
        public UcHollandResult()
        {
            InitializeComponent();
        }

        private void UcHollandResult_Load(object sender, EventArgs e)
        {
            if (_data != null)
            {
                DisplayResult(_data);
            }
        }

        // 3. Hàm hiển thị dữ liệu lên giao diện
        private void DisplayResult(HollandResultDto dto)
        {
            // Hiển thị mã (VD: R - I - A)
            char[] chars = dto.HollandCode.ToCharArray();
            lblCode.Text = string.Join(" - ", chars);

            // Hiển thị mô tả từ Server gửi về
            txtDescription.Text = dto.Description;

            // Load ngành gợi ý dựa trên nhóm mạnh nhất (chữ cái đầu tiên)
            LoadSuggestions(dto.HollandCode.Substring(0, 1));
        }

        // 4. Hàm gợi ý ngành nghề (Tận dụng logic switch-case của m nhưng viết gọn lại)
        private void LoadSuggestions(string type)
        {
            dgvSuggestions.Rows.Clear();

            // Ở đây m có thể viết logic dgvSuggestions.Rows.Add như cũ 
            // Hoặc tốt nhất là gọi API Majors để lấy ngành thật
            switch (type)
            {
                case "R": // Realistic
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Kỹ thuật – Công nghệ ứng dụng",
                        "95%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Cơ khí – Chế tạo – Sản xuất công nghiệp",
                        "92%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Công nghệ kỹ thuật và hệ thống máy móc",
                        "90%"
                    );
                    break;

                case "I": // Investigative
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Khoa học – Nghiên cứu – Phân tích dữ liệu",
                        "98%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Công nghệ thông tin và khoa học máy tính",
                        "95%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Y sinh – Khoa học sức khỏe – Công nghệ sinh học",
                        "88%"
                    );
                    break;

                case "A": // Artistic
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Sáng tạo – Nghệ thuật – Thiết kế",
                        "96%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Mỹ thuật ứng dụng và truyền thông thị giác",
                        "92%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Kiến trúc – Không gian – Thiết kế môi trường sống",
                        "88%"
                    );
                    break;

                case "S": // Social
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Giáo dục – Đào tạo – Phát triển con người",
                        "95%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Tâm lý – Công tác xã hội – Hỗ trợ cộng đồng",
                        "92%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Dịch vụ xã hội và quản lý nguồn nhân lực",
                        "90%"
                    );
                    break;

                case "E": // Enterprising
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Kinh doanh – Quản trị – Khởi nghiệp",
                        "96%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Marketing – Truyền thông – Chiến lược thương hiệu",
                        "94%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Quản lý – Lãnh đạo – Phát triển tổ chức",
                        "92%"
                    );
                    break;

                case "C": // Conventional
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Tài chính – Kế toán – Kiểm soát số liệu",
                        "98%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Ngân hàng – Bảo hiểm – Quản lý rủi ro",
                        "96%"
                    );
                    dgvSuggestions.Rows.Add(
                        "Nhóm ngành Hành chính – Văn phòng – Quản lý hệ thống",
                        "94%"
                    );
                    break;
            }

        }
    }
}