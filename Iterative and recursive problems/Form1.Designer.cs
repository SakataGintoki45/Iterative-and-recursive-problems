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
            label2 = new Label();
            btnIterativeFactorial = new Button();
            btnRecursiveFactorial = new Button();
            txtNumberFactorial = new TextBox();
            lblResultFactorial = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 15F);
            txtNumber.Location = new Point(64, 87);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(190, 34);
            txtNumber.TabIndex = 0;
            // 
            // btnRecursive
            // 
            btnRecursive.Location = new Point(21, 151);
            btnRecursive.Name = "btnRecursive";
            btnRecursive.Size = new Size(94, 41);
            btnRecursive.TabIndex = 1;
            btnRecursive.Text = "Recursive";
            btnRecursive.UseVisualStyleBackColor = true;
            btnRecursive.Click += btnRecursive_Click;
            // 
            // btnIterative
            // 
            btnIterative.Location = new Point(175, 151);
            btnIterative.Name = "btnIterative";
            btnIterative.Size = new Size(88, 41);
            btnIterative.TabIndex = 2;
            btnIterative.Text = "Iterative";
            btnIterative.UseVisualStyleBackColor = true;
            btnIterative.Click += btnIterative_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 290);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(123, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 4;
            label1.Text = "Fibnacci";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(513, 38);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 8;
            label2.Text = "Factorial";
            // 
            // btnIterativeFactorial
            // 
            btnIterativeFactorial.Location = new Point(565, 151);
            btnIterativeFactorial.Name = "btnIterativeFactorial";
            btnIterativeFactorial.Size = new Size(88, 41);
            btnIterativeFactorial.TabIndex = 7;
            btnIterativeFactorial.Text = "Iterative";
            btnIterativeFactorial.UseVisualStyleBackColor = true;
            btnIterativeFactorial.Click += btnIterativeFactorial_Click;
            // 
            // btnRecursiveFactorial
            // 
            btnRecursiveFactorial.Location = new Point(411, 151);
            btnRecursiveFactorial.Name = "btnRecursiveFactorial";
            btnRecursiveFactorial.Size = new Size(94, 41);
            btnRecursiveFactorial.TabIndex = 6;
            btnRecursiveFactorial.Text = "Recursive";
            btnRecursiveFactorial.UseVisualStyleBackColor = true;
            btnRecursiveFactorial.Click += btnRecursiveFactorial_Click;
            // 
            // txtNumberFactorial
            // 
            txtNumberFactorial.Font = new Font("Segoe UI", 15F);
            txtNumberFactorial.Location = new Point(454, 87);
            txtNumberFactorial.Name = "txtNumberFactorial";
            txtNumberFactorial.Size = new Size(190, 34);
            txtNumberFactorial.TabIndex = 5;
            // 
            // lblResultFactorial
            // 
            lblResultFactorial.AutoSize = true;
            lblResultFactorial.Location = new Point(427, 267);
            lblResultFactorial.Name = "lblResultFactorial";
            lblResultFactorial.Size = new Size(0, 15);
            lblResultFactorial.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultFactorial);
            Controls.Add(label2);
            Controls.Add(btnIterativeFactorial);
            Controls.Add(btnRecursiveFactorial);
            Controls.Add(txtNumberFactorial);
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
        private Label label2;
        private Button btnIterativeFactorial;
        private Button btnRecursiveFactorial;
        private TextBox txtNumberFactorial;
        private Label lblResultFactorial;
    }
}
