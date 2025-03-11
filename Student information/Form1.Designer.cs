namespace Student_information
{
    partial class ShowPic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentIDTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            majorTextBox = new TextBox();
            scoreTextBox = new TextBox();
            advisorComboBox = new ComboBox();
            highestScoreLabel = new Label();
            studentListBox = new ListBox();
            addButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            advisorSelectionComboBox = new ComboBox();
            showAdvisorDataButton = new Button();
            label8 = new Label();
            clearButton = new Button();
            pictureBoxPokemon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            SuspendLayout();
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Location = new Point(35, 55);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(199, 23);
            studentIDTextBox.TabIndex = 0;
            studentIDTextBox.TextChanged += textBox1_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(258, 57);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(120, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(398, 57);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(123, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // majorTextBox
            // 
            majorTextBox.Location = new Point(538, 57);
            majorTextBox.Name = "majorTextBox";
            majorTextBox.Size = new Size(116, 23);
            majorTextBox.TabIndex = 3;
            majorTextBox.TextChanged += textBox3_TextChanged;
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(675, 57);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(99, 23);
            scoreTextBox.TabIndex = 4;
            scoreTextBox.KeyPress += scoreTextBox_KeyPress;
            // 
            // advisorComboBox
            // 
            advisorComboBox.FormattingEnabled = true;
            advisorComboBox.Location = new Point(140, 123);
            advisorComboBox.Name = "advisorComboBox";
            advisorComboBox.Size = new Size(301, 23);
            advisorComboBox.TabIndex = 5;
            advisorComboBox.SelectedIndexChanged += advisorComboBox_SelectedIndexChanged;
            // 
            // highestScoreLabel
            // 
            highestScoreLabel.AutoSize = true;
            highestScoreLabel.Location = new Point(645, 131);
            highestScoreLabel.Name = "highestScoreLabel";
            highestScoreLabel.Size = new Size(66, 15);
            highestScoreLabel.TabIndex = 6;
            highestScoreLabel.Text = "ScoreHight";
            highestScoreLabel.Click += highestScoreLabel_Click;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(140, 163);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(491, 109);
            studentListBox.TabIndex = 7;
            studentListBox.SelectedIndexChanged += studentListBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(823, 50);
            addButton.Name = "addButton";
            addButton.Size = new Size(95, 35);
            addButton.TabIndex = 8;
            addButton.Text = "Save";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "SdudentID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 27);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 10;
            label2.Text = "Fristname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 27);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(538, 27);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "Major";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(675, 27);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 96);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 14;
            label6.Text = "Lecturer Advisoer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 131);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 15;
            label7.Text = "View";
            // 
            // advisorSelectionComboBox
            // 
            advisorSelectionComboBox.FormattingEnabled = true;
            advisorSelectionComboBox.Location = new Point(35, 383);
            advisorSelectionComboBox.Name = "advisorSelectionComboBox";
            advisorSelectionComboBox.Size = new Size(301, 23);
            advisorSelectionComboBox.TabIndex = 16;
            // 
            // showAdvisorDataButton
            // 
            showAdvisorDataButton.Location = new Point(373, 383);
            showAdvisorDataButton.Name = "showAdvisorDataButton";
            showAdvisorDataButton.Size = new Size(148, 23);
            showAdvisorDataButton.TabIndex = 17;
            showAdvisorDataButton.Text = "showAdvisorDataButton";
            showAdvisorDataButton.UseVisualStyleBackColor = true;
            showAdvisorDataButton.Click += showAdvisorDataButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(129, 352);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 18;
            label8.Text = "ShoseAdvisoer";
            label8.Click += label8_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(35, 122);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 19;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.Location = new Point(708, 208);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(219, 198);
            pictureBoxPokemon.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxPokemon.TabIndex = 20;
            pictureBoxPokemon.TabStop = false;
            // 
            // ShowPic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(pictureBoxPokemon);
            Controls.Add(clearButton);
            Controls.Add(label8);
            Controls.Add(showAdvisorDataButton);
            Controls.Add(advisorSelectionComboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(studentListBox);
            Controls.Add(highestScoreLabel);
            Controls.Add(advisorComboBox);
            Controls.Add(scoreTextBox);
            Controls.Add(majorTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(studentIDTextBox);
            Name = "ShowPic";
            Text = "S";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentIDTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox majorTextBox;
        private TextBox scoreTextBox;
        private ComboBox advisorComboBox;
        private Label highestScoreLabel;
        private ListBox studentListBox;
        private Button addButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox advisorSelectionComboBox;
        private Button showAdvisorDataButton;
        private Label label8;
        private Button clearButton;
        private PictureBox pictureBoxPokemon;
    }
}
