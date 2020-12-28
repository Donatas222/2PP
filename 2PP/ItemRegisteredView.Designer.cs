
namespace _2PP
{
    partial class ItemRegisteredView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.WishlistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Click += new System.EventHandler(this.DescriptionLabel_Click);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.Location = new System.Drawing.Point(102, 301);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(111, 31);
            this.AddToCartButton.TabIndex = 6;
            this.AddToCartButton.Text = "I Krepseli";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // WishlistButton
            // 
            this.WishlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WishlistButton.Location = new System.Drawing.Point(0, 275);
            this.WishlistButton.Name = "WishlistButton";
            this.WishlistButton.Size = new System.Drawing.Size(35, 26);
            this.WishlistButton.TabIndex = 7;
            this.WishlistButton.Text = "♥";
            this.WishlistButton.UseVisualStyleBackColor = true;
            this.WishlistButton.Click += new System.EventHandler(this.WishlistButton_Click);
            // 
            // ItemRegisteredView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WishlistButton);
            this.Controls.Add(this.AddToCartButton);
            this.Name = "ItemRegisteredView";
            this.Load += new System.EventHandler(this.ItemRegisteredView_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.DescriptionLabel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.PriceLabel, 0);
            this.Controls.SetChildIndex(this.CommentsButton, 0);
            this.Controls.SetChildIndex(this.AddToCartButton, 0);
            this.Controls.SetChildIndex(this.WishlistButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button AddToCartButton;
        protected System.Windows.Forms.Button WishlistButton;
    }
}
