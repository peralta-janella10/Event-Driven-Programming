namespace Cashier
{
    partial class QueuingFrom
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
            btnCashier = new Button();
            label1 = new Label();
            lblQueue = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Location = new Point(12, 12);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(150, 136);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 31);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(241, 88);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(104, 28);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 00000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(24, 151);
            label3.Name = "label3";
            label3.Size = new Size(110, 13);
            label3.TabIndex = 3;
            label3.Text = "*Click to get a number";
            // 
            // QueuingFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(420, 185);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "QueuingFrom";
            Text = "QueuingFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label lblQueue;
        private Label label3;
    }
}
