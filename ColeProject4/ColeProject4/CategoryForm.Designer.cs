namespace ColeProject4
{
    partial class CategoryForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.bikeButton = new System.Windows.Forms.Button();
            this.componentButton = new System.Windows.Forms.Button();
            this.clothingButton = new System.Windows.Forms.Button();
            this.accessoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(301, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(220, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Categories:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.MouseHover += new System.EventHandler(this.titleLabel_MouseHover);
            // 
            // bikeButton
            // 
            this.bikeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeButton.Location = new System.Drawing.Point(308, 98);
            this.bikeButton.Name = "bikeButton";
            this.bikeButton.Size = new System.Drawing.Size(213, 35);
            this.bikeButton.TabIndex = 1;
            this.bikeButton.Text = "Bikes";
            this.bikeButton.UseVisualStyleBackColor = true;
            this.bikeButton.Click += new System.EventHandler(this.bikeButton_Click);
            // 
            // componentButton
            // 
            this.componentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentButton.Location = new System.Drawing.Point(308, 139);
            this.componentButton.Name = "componentButton";
            this.componentButton.Size = new System.Drawing.Size(213, 35);
            this.componentButton.TabIndex = 2;
            this.componentButton.Text = "Components";
            this.componentButton.UseVisualStyleBackColor = true;
            this.componentButton.Click += new System.EventHandler(this.componentButton_Click);
            // 
            // clothingButton
            // 
            this.clothingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothingButton.Location = new System.Drawing.Point(308, 180);
            this.clothingButton.Name = "clothingButton";
            this.clothingButton.Size = new System.Drawing.Size(213, 35);
            this.clothingButton.TabIndex = 3;
            this.clothingButton.Text = "Clothing";
            this.clothingButton.UseVisualStyleBackColor = true;
            this.clothingButton.Click += new System.EventHandler(this.clothingButton_Click);
            // 
            // accessoryButton
            // 
            this.accessoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessoryButton.Location = new System.Drawing.Point(308, 221);
            this.accessoryButton.Name = "accessoryButton";
            this.accessoryButton.Size = new System.Drawing.Size(213, 35);
            this.accessoryButton.TabIndex = 4;
            this.accessoryButton.Text = "Accessories";
            this.accessoryButton.UseVisualStyleBackColor = true;
            this.accessoryButton.Click += new System.EventHandler(this.accessoryButton_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 339);
            this.Controls.Add(this.accessoryButton);
            this.Controls.Add(this.clothingButton);
            this.Controls.Add(this.componentButton);
            this.Controls.Add(this.bikeButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "CategoryForm";
            this.Text = "Categories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button bikeButton;
        private System.Windows.Forms.Button componentButton;
        private System.Windows.Forms.Button clothingButton;
        private System.Windows.Forms.Button accessoryButton;
    }
}

