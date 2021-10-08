
namespace Árajánlat_Készítő
{
    partial class Form1
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
            this.addNewElementBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.FileReadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ClearListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewElementBtn
            // 
            this.addNewElementBtn.Location = new System.Drawing.Point(12, 38);
            this.addNewElementBtn.Name = "addNewElementBtn";
            this.addNewElementBtn.Size = new System.Drawing.Size(142, 39);
            this.addNewElementBtn.TabIndex = 0;
            this.addNewElementBtn.Text = "Hozzáadás";
            this.addNewElementBtn.UseVisualStyleBackColor = true;
            this.addNewElementBtn.Click += new System.EventHandler(this.AddNewElementBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 83);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(244, 319);
            this.checkedListBox1.TabIndex = 2;
            // 
            // FileReadBtn
            // 
            this.FileReadBtn.Location = new System.Drawing.Point(160, 12);
            this.FileReadBtn.Name = "FileReadBtn";
            this.FileReadBtn.Size = new System.Drawing.Size(96, 65);
            this.FileReadBtn.TabIndex = 3;
            this.FileReadBtn.Text = "Fájl beolvasás";
            this.FileReadBtn.UseVisualStyleBackColor = true;
            this.FileReadBtn.Click += new System.EventHandler(this.FileReadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 415);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(244, 23);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Lista mentése";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClearListBtn
            // 
            this.ClearListBtn.Location = new System.Drawing.Point(713, 415);
            this.ClearListBtn.Name = "ClearListBtn";
            this.ClearListBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearListBtn.TabIndex = 5;
            this.ClearListBtn.Text = "Lista törlése";
            this.ClearListBtn.UseVisualStyleBackColor = true;
            this.ClearListBtn.Click += new System.EventHandler(this.ClearListBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearListBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FileReadBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addNewElementBtn);
            this.Name = "Form1";
            this.Text = "Árajánlat Készítő";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewElementBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button FileReadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ClearListBtn;
    }
}

