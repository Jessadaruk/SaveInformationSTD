namespace Student_information
{
    public partial class ShowPic : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();


        public ShowPic()
        {
            InitializeComponent();
            InitializeAdvisors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // กำหนดพาธของรูปภาพ
            string imagePath = @"Image\Hello.png";

            // ตรวจสอบว่าไฟล์รูปภาพมีอยู่จริงหรือไม่
            if (System.IO.File.Exists(imagePath))
            {
                // โหลดรูปภาพและแสดงใน PictureBox
                pictureBoxPokemon.Image = System.Drawing.Image.FromFile(imagePath);

            }
        }

       


        private void InitializeAdvisors()
        {
            
            Advisor advisor1 = new Advisor("John", "Doe", "Computer Science");
            Advisor advisor2 = new Advisor("Jane", "Smith", "Information Technology");
            Advisor advisor3 = new Advisor("David", "Lee", "Mathematics");
            Advisor advisor4 = new Advisor("Sarah", "Kim", "Physics");
            Advisor advisor5 = new Advisor("Michael", "Brown", "Chemistry");

            
            advisors.Add(advisor1);
            advisors.Add(advisor2);
            advisors.Add(advisor3);
            advisors.Add(advisor4);
            advisors.Add(advisor5);

            
            advisorComboBox.DataSource = advisors;
            advisorComboBox.DisplayMember = "DisplayAdvisorInfo"; 
            advisorSelectionComboBox.DataSource = advisors;
            advisorSelectionComboBox.DisplayMember = "DisplayAdvisorInfo";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get student data from text boxes
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string major = majorTextBox.Text;
            string studentID = studentIDTextBox.Text;
            Advisor advisor = (Advisor)advisorComboBox.SelectedItem;
            double score = double.Parse(scoreTextBox.Text);

            // Create new student object
            Student student = new Student(firstName, lastName, major, studentID, advisor, score);

            // Add student to list and list box
            students.Add(student);
            

            if (advisor.Students.Any(s => s.StudentID == studentID))
            {
                MessageBox.Show("Not use the same ID", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }




            // เพิ่มนักศึกษาใน List และ ListBox พร้อมข้อความ "เพิ่มข้อมูลแล้ว" ในบรรทัดเดียวกัน
            students.Add(student);
            studentListBox.Items.Add(student); // เพิ่มอ็อบเจ็กต์ Student โดยตรง


            // Add student to advisor's list
            advisor.AddStudent(student);

            // Update highest score student
            UpdateHighestScoreStudent();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected advisor from list box
            
            Student selectedStudent = studentListBox.SelectedItem as Student;
            // Show advisor form with list of students

            AdvisorForm advisorForm = new AdvisorForm(selectedStudent.Advisor);
            advisorForm.Show();


        }

        private void UpdateHighestScoreStudent()
        {
            if (students.Count > 0)
            {
                Student highestScoreStudent = students[0];
                foreach (Student student in students)
                {
                    if (student.Score > highestScoreStudent.Score)
                    {
                        highestScoreStudent = student;
                    }
                }
                highestScoreLabel.Text = $"Highest Score: {highestScoreStudent.FirstName} {highestScoreStudent.LastName} ({highestScoreStudent.Score})";
            }
            else
            {
                highestScoreLabel.Text = "Highest Score: None";
            }
        }

        private void advisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showAdvisorDataButton_Click(object sender, EventArgs e)
        {
            
            Advisor selectedAdvisor = (Advisor)advisorSelectionComboBox.SelectedItem;

            
            AdvisorForm advisorForm = new AdvisorForm(selectedAdvisor);
            advisorForm.Show();
        }

        private void highestScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            
            studentIDTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            majorTextBox.Text = "";
            scoreTextBox.Text = "";

            
            if (advisorComboBox.Items.Count > 0)
            {
                advisorComboBox.SelectedIndex = 0;
            }

            
            if (advisorSelectionComboBox.Items.Count > 0)
            {
                advisorSelectionComboBox.SelectedIndex = 0;
            }
        }

        private void scoreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        
    }

}

