namespace ColeProject4
{
    partial class AccessoryForm
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
            this.accessoryGrid = new System.Windows.Forms.DataGridView();
            this.accessoryLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryGrid)).BeginInit();
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
            // accessoryGrid
            // 
            this.accessoryGrid.AllowUserToAddRows = false;
            this.accessoryGrid.AllowUserToDeleteRows = false;
            this.accessoryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accessoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.accessoryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.accessoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessoryGrid.Location = new System.Drawing.Point(7, 124);
            this.accessoryGrid.Name = "accessoryGrid";
            this.accessoryGrid.Size = new System.Drawing.Size(787, 320);
            this.accessoryGrid.TabIndex = 8;
            // 
            // accessoryLabel
            // 
            this.accessoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accessoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessoryLabel.Location = new System.Drawing.Point(320, 9);
            this.accessoryLabel.Name = "accessoryLabel";
            this.accessoryLabel.Size = new System.Drawing.Size(199, 37);
            this.accessoryLabel.TabIndex = 7;
            this.accessoryLabel.Text = "Accessories";
            this.accessoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // AccessoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.numRecordsLabel);
            this.Controls.Add(this.accessoryGrid);
            this.Controls.Add(this.accessoryLabel);
            this.Name = "AccessoryForm";
            this.Text = "Accessories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccessoryForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.accessoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numRecordsLabel;
        private System.Windows.Forms.DataGridView accessoryGrid;
        private System.Windows.Forms.Label accessoryLabel;
        private System.Windows.Forms.Button backButton;
    }
}