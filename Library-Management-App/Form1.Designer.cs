namespace Library_Management_App
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
            this.btn_getImage = new System.Windows.Forms.Button();
            this.tbx_searchImage = new System.Windows.Forms.TextBox();
            this.pbx_searchedBook = new System.Windows.Forms.PictureBox();
            this.lbl_url = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_searchedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getImage
            // 
            this.btn_getImage.Location = new System.Drawing.Point(292, 135);
            this.btn_getImage.Name = "btn_getImage";
            this.btn_getImage.Size = new System.Drawing.Size(75, 23);
            this.btn_getImage.TabIndex = 0;
            this.btn_getImage.Text = "Search";
            this.btn_getImage.UseVisualStyleBackColor = true;
            this.btn_getImage.Click += new System.EventHandler(this.btn_getImage_Click);
            // 
            // tbx_searchImage
            // 
            this.tbx_searchImage.Location = new System.Drawing.Point(404, 135);
            this.tbx_searchImage.Name = "tbx_searchImage";
            this.tbx_searchImage.Size = new System.Drawing.Size(100, 23);
            this.tbx_searchImage.TabIndex = 1;
            // 
            // pbx_searchedBook
            // 
            this.pbx_searchedBook.Location = new System.Drawing.Point(324, 183);
            this.pbx_searchedBook.Name = "pbx_searchedBook";
            this.pbx_searchedBook.Size = new System.Drawing.Size(139, 165);
            this.pbx_searchedBook.TabIndex = 2;
            this.pbx_searchedBook.TabStop = false;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(292, 101);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(21, 15);
            this.lbl_url.TabIndex = 3;
            this.lbl_url.Text = "url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.pbx_searchedBook);
            this.Controls.Add(this.tbx_searchImage);
            this.Controls.Add(this.btn_getImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_searchedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_getImage;
        private TextBox tbx_searchImage;
        private PictureBox pbx_searchedBook;
        private Label lbl_url;
    }
}