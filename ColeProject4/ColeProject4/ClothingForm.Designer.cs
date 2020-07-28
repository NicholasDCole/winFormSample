namespace ColeProject4
{
    partial class ClothingForm
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
            this.numRecordsLabel = new System.Windows.Forms.Label();
            this.clothingGrid = new System.Windows.Forms.DataGridView();
            this.clothingLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clothingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // numRecordsLabel
            // 
            this.numRecordsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRecordsLabel.CausesValidation = false;
            this.numRecordsLabel.Location = new System.Drawing.Point(320, 86);
            this.numRecordsLabel.Name = "numRecordsLabel";
            this.numRecordsLabel.Size = new System.Drawing.Size(199, 37);
            this.numRecordsLabel.TabIndex = 9;
            this.numRecordsLabel.Text = "# of Records";
            this.numRecordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clothingGrid
            // 
            this.clothingGrid.AllowUserToAddRows = false;
            this.clothingGrid.AllowUserToDeleteRows = false;
            this.clothingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clothingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clothingGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clothingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clothingGrid.Location = new System.Drawing.Point(7, 124);
            this.clothingGrid.Name = "clothingGrid";
            this.clothingGrid.Size = new System.Drawing.Size(787, 320);
            this.clothingGrid.TabIndex = 8;
            // 
            // clothingLabel
            // 
            this.clothingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clothingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothingLabel.Location = new System.Drawing.Point(320, 9);
            this.clothingLabel.Name = "clothingLabel";
            this.clothingLabel.Size = new System.Drawing.Size(199, 37);
            this.clothingLabel.TabIndex = 7;
            this.clothingLabel.Text = "Clothing";
            this.clothingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(7, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 26);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ClothingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.numRecordsLabel);
            this.Controls.Add(this.clothingGrid);
            this.Controls.Add(this.clothingLabel);
            this.Name = "ClothingForm";
            this.Text = "Clothing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClothingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.clothingGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numRecordsLabel;
        private System.Windows.Forms.DataGridView clothingGrid;
        private System.Windows.Forms.Label clothingLabel;
        private System.Windows.Forms.Button backButton;
    }
}