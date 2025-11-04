namespace Torre_di_hanoi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Base = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sel_Rings = new System.Windows.Forms.NumericUpDown();
            this.btn_Start = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sel_Rings)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Base
            // 
            this.Pnl_Base.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pnl_Base.Location = new System.Drawing.Point(70, 300);
            this.Pnl_Base.Name = "Pnl_Base";
            this.Pnl_Base.Size = new System.Drawing.Size(150, 15);
            this.Pnl_Base.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(250, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 15);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(430, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 15);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(138, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 200);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(318, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 200);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(498, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 200);
            this.panel6.TabIndex = 3;
            // 
            // sel_Rings
            // 
            this.sel_Rings.Location = new System.Drawing.Point(43, 47);
            this.sel_Rings.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.sel_Rings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sel_Rings.Name = "sel_Rings";
            this.sel_Rings.Size = new System.Drawing.Size(150, 20);
            this.sel_Rings.TabIndex = 4;
            this.sel_Rings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(43, 73);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(150, 20);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Inizia";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.btn_Start);
            this.panel7.Controls.Add(this.sel_Rings);
            this.panel7.Location = new System.Drawing.Point(711, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 111);
            this.panel7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELEZIONA IL  NUMERO DI ANELLI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Pnl_Base);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sel_Rings)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Base;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown sel_Rings;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}

