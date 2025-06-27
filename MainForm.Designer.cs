namespace CybersecurityChatbotGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageChat = new TabPage();
            txtChatOutput = new RichTextBox();
            panel1 = new Panel();
            txtUserInput = new TextBox();
            btnSend = new Button();
            tabPageTasks = new TabPage();
            listTasks = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel2 = new Panel();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            btnAddTask = new Button();
            dateTimeReminder = new DateTimePicker();
            label2 = new Label();
            txtTaskDescription = new TextBox();
            label1 = new Label();
            txtTaskTitle = new TextBox();
            tabPageQuiz = new TabPage();
            lblQuestion = new Label();
            btnOptionA = new Button();
            btnOptionB = new Button();
            btnOptionC = new Button();
            btnOptionD = new Button();
            lblFeedback = new Label();
            lblScore = new Label();
            btnNextQuestion = new Button();

            tabControl1.SuspendLayout();
            tabPageChat.SuspendLayout();
            panel1.SuspendLayout();
            tabPageTasks.SuspendLayout();
            panel2.SuspendLayout();
            tabPageQuiz.SuspendLayout();
            SuspendLayout();

            // tabControl1
            tabControl1.Controls.Add(tabPageChat);
            tabControl1.Controls.Add(tabPageTasks);
            tabControl1.Controls.Add(tabPageQuiz);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;

            // tabPageChat
            tabPageChat.Controls.Add(panel1);            // add input panel first
            tabPageChat.Controls.Add(txtChatOutput);    // then add output panel
            tabPageChat.Location = new Point(4, 29);
            tabPageChat.Name = "tabPageChat";
            tabPageChat.Padding = new Padding(3);
            tabPageChat.Size = new Size(792, 417);
            tabPageChat.TabIndex = 0;
            tabPageChat.Text = "Chat";
            tabPageChat.UseVisualStyleBackColor = true;

            // txtChatOutput
            txtChatOutput.BackColor = Color.FromArgb(30, 30, 30);
            txtChatOutput.Dock = DockStyle.Fill;
            txtChatOutput.Font = new Font("Consolas", 10F);
            txtChatOutput.ForeColor = Color.White;
            txtChatOutput.Location = new Point(3, 3);
            txtChatOutput.ReadOnly = true;
            txtChatOutput.Size = new Size(786, 375);
            txtChatOutput.TabIndex = 0;
            txtChatOutput.Text = "";

            // panel1 - bottom input panel
            panel1.Dock = DockStyle.Bottom;
            panel1.Height = 45;
            panel1.BackColor = SystemColors.Control;
            panel1.Padding = new Padding(10);
            panel1.Controls.Add(txtUserInput);
            panel1.Controls.Add(btnSend);

            // txtUserInput - user input textbox
            txtUserInput.Location = new Point(10, 10);
            txtUserInput.Size = new Size(660, 25);
            txtUserInput.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            txtUserInput.Multiline = false;
            txtUserInput.ReadOnly = false;
            txtUserInput.TabIndex = 0;

            // btnSend - send button
            btnSend.Location = new Point(680, 10);
            btnSend.Size = new Size(90, 25);
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Text = "Send";
            btnSend.TabIndex = 1;
            btnSend.Click += btnSend_Click;

            // tabPageTasks
            tabPageTasks.Controls.Add(listTasks);
            tabPageTasks.Controls.Add(panel2);
            tabPageTasks.Location = new Point(4, 29);
            tabPageTasks.Size = new Size(792, 417);
            tabPageTasks.Text = "Tasks";
            tabPageTasks.UseVisualStyleBackColor = true;

            // listTasks
            listTasks.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listTasks.Dock = DockStyle.Fill;
            listTasks.FullRowSelect = true;
            listTasks.View = View.Details;

            columnHeader1.Text = "Task";
            columnHeader1.Width = 200;
            columnHeader2.Text = "Description";
            columnHeader2.Width = 300;
            columnHeader3.Text = "Due Date";
            columnHeader3.Width = 150;

            // panel2 - task input and controls
            panel2.Controls.Add(btnDeleteTask);
            panel2.Controls.Add(btnCompleteTask);
            panel2.Controls.Add(btnAddTask);
            panel2.Controls.Add(dateTimeReminder);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTaskDescription);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTaskTitle);
            panel2.Dock = DockStyle.Bottom;
            panel2.Size = new Size(786, 82);

            btnDeleteTask.Location = new Point(600, 45);
            btnDeleteTask.Size = new Size(120, 30);
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.Click += btnDeleteTask_Click;

            btnCompleteTask.Location = new Point(600, 9);
            btnCompleteTask.Size = new Size(120, 30);
            btnCompleteTask.Text = "Mark Complete";
            btnCompleteTask.Click += btnCompleteTask_Click;

            btnAddTask.Location = new Point(450, 45);
            btnAddTask.Size = new Size(120, 30);
            btnAddTask.Text = "Add Task";
            btnAddTask.Click += btnAddTask_Click;

            dateTimeReminder.Format = DateTimePickerFormat.Short;
            dateTimeReminder.Location = new Point(450, 11);
            dateTimeReminder.Size = new Size(120, 27);

            label2.Location = new Point(150, 15);
            label2.Text = "Description";
            label2.AutoSize = true;

            txtTaskDescription.Location = new Point(150, 45);
            txtTaskDescription.Size = new Size(280, 27);

            label1.Location = new Point(15, 15);
            label1.Text = "Title";
            label1.AutoSize = true;

            txtTaskTitle.Location = new Point(15, 45);
            txtTaskTitle.Size = new Size(120, 27);

            // tabPageQuiz
            tabPageQuiz.Controls.Add(lblQuestion);
            tabPageQuiz.Controls.Add(btnOptionA);
            tabPageQuiz.Controls.Add(btnOptionB);
            tabPageQuiz.Controls.Add(btnOptionC);
            tabPageQuiz.Controls.Add(btnOptionD);
            tabPageQuiz.Controls.Add(lblFeedback);
            tabPageQuiz.Controls.Add(lblScore);
            tabPageQuiz.Controls.Add(btnNextQuestion);
            tabPageQuiz.Location = new Point(4, 29);
            tabPageQuiz.Text = "Quiz";
            tabPageQuiz.UseVisualStyleBackColor = true;

            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQuestion.Location = new Point(20, 20);
            lblQuestion.Text = "Question will appear here";

            btnOptionA.Location = new Point(20, 80);
            btnOptionA.Size = new Size(350, 40);
            btnOptionA.Text = "Option A";
            btnOptionA.Click += btnOptionA_Click;

            btnOptionB.Location = new Point(400, 80);
            btnOptionB.Size = new Size(350, 40);
            btnOptionB.Text = "Option B";
            btnOptionB.Click += btnOptionB_Click;

            btnOptionC.Location = new Point(20, 130);
            btnOptionC.Size = new Size(350, 40);
            btnOptionC.Text = "Option C";
            btnOptionC.Click += btnOptionC_Click;

            btnOptionD.Location = new Point(400, 130);
            btnOptionD.Size = new Size(350, 40);
            btnOptionD.Text = "Option D";
            btnOptionD.Click += btnOptionD_Click;

            lblFeedback.AutoSize = true;
            lblFeedback.Font = new Font("Segoe UI", 10F);
            lblFeedback.Location = new Point(20, 190);
            lblFeedback.Text = "Feedback will appear here";

            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 10F);
            lblScore.Location = new Point(20, 230);
            lblScore.Text = "Score: 0";

            btnNextQuestion.Location = new Point(600, 230);
            btnNextQuestion.Size = new Size(150, 40);
            btnNextQuestion.Text = "Next Question";
            btnNextQuestion.Click += btnNextQuestion_Click;

            // MainForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Cybersecurity Chatbot";

            tabControl1.ResumeLayout(false);
            tabPageChat.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageTasks.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPageQuiz.ResumeLayout(false);
            tabPageQuiz.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageChat;
        private TabPage tabPageTasks;
        private TabPage tabPageQuiz;
        private RichTextBox txtChatOutput;
        private Panel panel1;
        private Button btnSend;
        private TextBox txtUserInput;
        private ListView listTasks;
        private Panel panel2;
        private Button btnDeleteTask;
        private Button btnCompleteTask;
        private Button btnAddTask;
        private DateTimePicker dateTimeReminder;
        private Label label2;
        private TextBox txtTaskDescription;
        private Label label1;
        private TextBox txtTaskTitle;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;

        private Label lblQuestion;
        private Button btnOptionA;
        private Button btnOptionB;
        private Button btnOptionC;
        private Button btnOptionD;
        private Label lblFeedback;
        private Label lblScore;
        private Button btnNextQuestion;
    }
}
