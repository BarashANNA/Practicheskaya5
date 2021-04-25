namespace FlyBallon
{
    partial class AddNewRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRecord));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewBalloon = new System.Windows.Forms.TextBox();
            this.NewPrice = new System.Windows.Forms.TextBox();
            this.NewPhone = new System.Windows.Forms.TextBox();
            this.AddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Полет на шаре";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(99, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NewBalloon
            // 
            this.NewBalloon.Location = new System.Drawing.Point(240, 26);
            this.NewBalloon.Multiline = true;
            this.NewBalloon.Name = "NewBalloon";
            this.NewBalloon.Size = new System.Drawing.Size(206, 31);
            this.NewBalloon.TabIndex = 4;
            this.NewBalloon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewPrice
            // 
            this.NewPrice.Location = new System.Drawing.Point(240, 73);
            this.NewPrice.Multiline = true;
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.Size = new System.Drawing.Size(206, 31);
            this.NewPrice.TabIndex = 5;
            // 
            // NewPhone
            // 
            this.NewPhone.Location = new System.Drawing.Point(240, 118);
            this.NewPhone.Multiline = true;
            this.NewPhone.Name = "NewPhone";
            this.NewPhone.Size = new System.Drawing.Size(206, 31);
            this.NewPhone.TabIndex = 6;
            // 
            // AddNew
            // 
            this.AddNew.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNew.Location = new System.Drawing.Point(547, 26);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(212, 87);
            this.AddNew.TabIndex = 7;
            this.AddNew.Text = "Добавить";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // AddNewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.NewPhone);
            this.Controls.Add(this.NewPrice);
            this.Controls.Add(this.NewBalloon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddNewRecord";
            this.Text = "AddNewRecord";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NewBalloon;
        private System.Windows.Forms.TextBox NewPrice;
        private System.Windows.Forms.TextBox NewPhone;
        private System.Windows.Forms.Button AddNew;
    }
}