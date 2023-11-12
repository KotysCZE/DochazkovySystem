namespace DochazkovySystem
{
    partial class Form1
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
            arrival = new Button();
            leave = new Button();
            employeeNumberTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // arrival
            // 
            arrival.Location = new Point(82, 94);
            arrival.Name = "arrival";
            arrival.Size = new Size(78, 52);
            arrival.TabIndex = 0;
            arrival.Text = "Příchod";
            arrival.UseVisualStyleBackColor = true;
            arrival.Click += arrival_Click;
            // 
            // leave
            // 
            leave.Location = new Point(202, 94);
            leave.Name = "leave";
            leave.Size = new Size(88, 52);
            leave.TabIndex = 1;
            leave.Text = "Odchod";
            leave.UseVisualStyleBackColor = true;
            leave.Click += leave_Click;
            // 
            // employeeNumberTextBox
            // 
            employeeNumberTextBox.Location = new Point(148, 50);
            employeeNumberTextBox.Name = "employeeNumberTextBox";
            employeeNumberTextBox.Size = new Size(173, 23);
            employeeNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 3;
            label1.Text = "Číslo zaměstnance: ";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 204);
            Controls.Add(label1);
            Controls.Add(employeeNumberTextBox);
            Controls.Add(leave);
            Controls.Add(arrival);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button arrival;
        private Button leave;
        private TextBox employeeNumberTextBox;
        private Label label1;
    }
}