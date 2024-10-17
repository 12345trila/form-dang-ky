using System.Text.RegularExpressions;

namespace form_dangky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_dangky_Click(object sender, EventArgs e)
        {
            string Email = email.Text;
            string Password = Pass.Text;
            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPassword(Password))
            {
                MessageBox.Show("Mật khẩu phải tối thiểu 8 ký tự và chứa ít nhất 1 ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool IsValidEmail(string Email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(Email, pattern);
        }
        private bool IsValidPassword(string Password)
        {
            if (Password.Length < 8) return false;

            string specialCharPattern = @"[!@#$%^&*(),.?\:{ }|<>]";
            return Regex.IsMatch(Password, specialCharPattern);
        }
    }
}
   
