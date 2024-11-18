namespace Iterative_and_recursive_problems
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
            txtNumber = new TextBox();
            btnRecursive = new Button();
            btnIterative = new Button();
            lblResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 15F);
            txtNumber.Location = new Point(289, 86);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(190, 34);
            txtNumber.TabIndex = 0;
            // 
            // btnRecursive
            // 
            btnRecursive.Location = new Point(169, 151);
            btnRecursive.Name = "btnRecursive";
            btnRecursive.Size = new Size(176, 41);
            btnRecursive.TabIndex = 1;
            btnRecursive.Text = "Recursive";
            btnRecursive.UseVisualStyleBackColor = true;
            btnRecursive.Click += btnRecursive_Click;
            // 
            // btnIterative
            // 
            btnIterative.Location = new Point(428, 151);
            btnIterative.Name = "btnIterative";
            btnIterative.Size = new Size(176, 41);
            btnIterative.TabIndex = 2;
            btnIterative.Text = "Iterative";
            btnIterative.UseVisualStyleBackColor = true;
            btnIterative.Click += btnIterative_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(247, 262);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(337, 35);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 4;
            label1.Text = "Fibnacci";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnIterative);
            Controls.Add(btnRecursive);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnRecursive;
        private Button btnIterative;
        private Label lblResult;
        private Label label1;
    }
}
