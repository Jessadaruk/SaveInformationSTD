using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_information
{
    internal class AdvisorForm : Form
    {
        private ListBox studentListBox;

        public AdvisorForm(Advisor advisor)
        {
            InitializeComponent(); 
            Text = $"Students of {advisor.FirstName} {advisor.LastName}";

            // Populate student list box
            foreach (Student student in advisor.Students)
            {
                studentListBox.Items.Add(student);
            }
        }

        private void InitializeComponent() // InitializeComponent()
        {
            studentListBox = new ListBox();
            SuspendLayout();
            
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(12, 12);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(772, 229);
            studentListBox.TabIndex = 0;
            
            ClientSize = new Size(822, 261);
            Controls.Add(studentListBox);
            Name = "AdvisorForm";
            ResumeLayout(false);
        }
    }
}

