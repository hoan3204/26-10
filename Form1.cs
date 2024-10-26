namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Dictionary<string, string> studentScores = new Dictionary<string, string>()
        {
            { "22810310375", "Điểm: 8.5" },
            { "22810310360", "Điểm: 7.0" },
            { "22810310365", "Điểm: 9.0" } 
        };

        

        private void btnLookup_Click(object sender, EventArgs e)
        {
            // Lấy mã sinh viên từ TextBox
            string studentID = txtStudentID.Text.Trim();

            // Kiểm tra xem mã sinh viên có trong danh sách không
            if (studentScores.TryGetValue(studentID, out string score))
            {
                lblResult.Text = $"Thông tin sinh viên:\nMã: {studentID}\n{score}";
            }
            else
            {
                lblResult.Text = "Không tìm thấy sinh viên.";
            }
        }

        }
}
