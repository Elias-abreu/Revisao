namespace Revisao
{
    partial class Divisao
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
            this.tx_valor1 = new System.Windows.Forms.TextBox();
            this.tx_valor2 = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.lb_resultdo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_valor1
            // 
            this.tx_valor1.Location = new System.Drawing.Point(45, 42);
            this.tx_valor1.Name = "tx_valor1";
            this.tx_valor1.Size = new System.Drawing.Size(123, 20);
            this.tx_valor1.TabIndex = 0;
            // 
            // tx_valor2
            // 
            this.tx_valor2.Location = new System.Drawing.Point(45, 93);
            this.tx_valor2.Name = "tx_valor2";
            this.tx_valor2.Size = new System.Drawing.Size(123, 20);
            this.tx_valor2.TabIndex = 1;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(45, 170);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(123, 33);
            this.bt_calcular.TabIndex = 2;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // lb_resultdo
            // 
            this.lb_resultdo.AutoSize = true;
            this.lb_resultdo.Location = new System.Drawing.Point(42, 132);
            this.lb_resultdo.Name = "lb_resultdo";
            this.lb_resultdo.Size = new System.Drawing.Size(35, 13);
            this.lb_resultdo.TabIndex = 3;
            this.lb_resultdo.Text = "label1";
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 231);
            this.Controls.Add(this.lb_resultdo);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tx_valor2);
            this.Controls.Add(this.tx_valor1);
            this.Name = "Divisao";
            this.Text = "Divisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_valor1;
        private System.Windows.Forms.TextBox tx_valor2;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label lb_resultdo;
    }
}