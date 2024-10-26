namespace WinFormsApp1
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
            btnLookup = new Button();
            txtStudentID = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnLookup
            // 
            btnLookup.Location = new Point(381, 148);
            btnLookup.Name = "btnLookup";
            btnLookup.Size = new Size(94, 29);
            btnLookup.TabIndex = 0;
            btnLookup.Text = "Tra cứu";
            btnLookup.UseVisualStyleBackColor = true;
            btnLookup.Click += btnLookup_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(153, 148);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(164, 27);
            txtStudentID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 148);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã sinh viên:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(176, 252);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(12, 20);
            lblResult.TabIndex = 3;
            lblResult.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtStudentID);
            Controls.Add(btnLookup);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLookup;
        private TextBox txtStudentID;
        private Label label1;
        private Label lblResult;
    }
}
