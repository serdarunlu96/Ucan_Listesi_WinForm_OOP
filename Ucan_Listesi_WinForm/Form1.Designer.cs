namespace Ucan_Listesi_WinForm
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
            lstUcanlar = new ListBox();
            btnTumunuUcur = new Button();
            SuspendLayout();
            // 
            // lstUcanlar
            // 
            lstUcanlar.FormattingEnabled = true;
            lstUcanlar.ItemHeight = 15;
            lstUcanlar.Location = new Point(32, 31);
            lstUcanlar.Name = "lstUcanlar";
            lstUcanlar.Size = new Size(343, 259);
            lstUcanlar.TabIndex = 0;
            // 
            // btnTumunuUcur
            // 
            btnTumunuUcur.Location = new Point(32, 315);
            btnTumunuUcur.Name = "btnTumunuUcur";
            btnTumunuUcur.Size = new Size(343, 23);
            btnTumunuUcur.TabIndex = 1;
            btnTumunuUcur.Text = "TUMUNU UCUR";
            btnTumunuUcur.UseVisualStyleBackColor = true;
            btnTumunuUcur.Click += btnTumunuUcur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 363);
            Controls.Add(btnTumunuUcur);
            Controls.Add(lstUcanlar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstUcanlar;
        private Button btnTumunuUcur;
    }
}