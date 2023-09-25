namespace CalculatorApplication
{
    partial class FrmCalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDisplayTotal = new Label();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 40);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(124, 157);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 2;
            label3.Text = "Answer :";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(204, 157);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(0, 21);
            lblDisplayTotal.TabIndex = 3;
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.Location = new Point(204, 36);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(160, 29);
            txtBoxInput1.TabIndex = 5;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.Location = new Point(204, 118);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(160, 26);
            txtBoxInput2.TabIndex = 6;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(204, 78);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(160, 27);
            cbOperator.TabIndex = 7;
            cbOperator.SelectedIndexChanged += cbOperator_SelectedIndexChanged;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(232, 205);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(114, 29);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btncalculate_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 260);
            Controls.Add(btnEqual);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalculator";
            Text = "Form1";
            Load += FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDisplayTotal;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Button btnEqual;
    }
}