namespace Firat.Asistan.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtxtSohbet = new System.Windows.Forms.RichTextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lstGecmis = new System.Windows.Forms.ListBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();

      
            this.rtxtSohbet.BackColor = System.Drawing.Color.LightYellow;
            this.rtxtSohbet.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rtxtSohbet.Location = new System.Drawing.Point(210, 50);
            this.rtxtSohbet.Name = "rtxtSohbet";
            this.rtxtSohbet.ReadOnly = true;
            this.rtxtSohbet.Size = new System.Drawing.Size(530, 450);
            this.rtxtSohbet.TabIndex = 0;
            this.rtxtSohbet.Text = "";

            // txtMesaj
            this.txtMesaj.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtMesaj.Location = new System.Drawing.Point(210, 510);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(420, 40);
            this.txtMesaj.TabIndex = 1;

            this.btnGonder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGonder.Location = new System.Drawing.Point(640, 510);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 40);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);

           
            this.lstGecmis.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lstGecmis.FormattingEnabled = true;
            this.lstGecmis.Location = new System.Drawing.Point(12, 50);
            this.lstGecmis.Name = "lstGecmis";
            this.lstGecmis.Size = new System.Drawing.Size(180, 500);
            this.lstGecmis.TabIndex = 3;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 581); // 770x700 altı [cite: 429]
            this.Controls.Add(this.lstGecmis);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.rtxtSohbet);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "Form1";
            this.Text = "Firat AI Asistan";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox rtxtSohbet;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ListBox lstGecmis;
        private System.Windows.Forms.Label lblBaslik;
    }
}