namespace UhlSport
{
    partial class FrmPayPartOfDues_SingleSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txDues = new System.Windows.Forms.TextBox();
            this.btnPayRemainderOfDues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "كم المبلغ الذي يريد العميل دفعه";
            // 
            // txDues
            // 
            this.txDues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDues.Location = new System.Drawing.Point(124, 126);
            this.txDues.Name = "txDues";
            this.txDues.Size = new System.Drawing.Size(217, 28);
            this.txDues.TabIndex = 1;
            // 
            // btnPayRemainderOfDues
            // 
            this.btnPayRemainderOfDues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayRemainderOfDues.Location = new System.Drawing.Point(286, 323);
            this.btnPayRemainderOfDues.Name = "btnPayRemainderOfDues";
            this.btnPayRemainderOfDues.Size = new System.Drawing.Size(113, 33);
            this.btnPayRemainderOfDues.TabIndex = 2;
            this.btnPayRemainderOfDues.Text = "دفع";
            this.btnPayRemainderOfDues.UseVisualStyleBackColor = true;
            this.btnPayRemainderOfDues.Click += new System.EventHandler(this.btnPayRemainderOfDues_Click);
            // 
            // FrmPayPartOfDues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 392);
            this.Controls.Add(this.btnPayRemainderOfDues);
            this.Controls.Add(this.txDues);
            this.Controls.Add(this.label1);
            this.Name = "FrmPayPartOfDues";
            this.Text = "PayPartOfDues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txDues;
        private System.Windows.Forms.Button btnPayRemainderOfDues;
    }
}