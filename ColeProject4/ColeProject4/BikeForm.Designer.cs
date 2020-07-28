namespace ColeProject4
{
    partial class BikeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bikeGrid = new System.Windows.Forms.DataGridView();
            this.numRecordsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bikeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bikes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bikeGrid
            // 
            this.bikeGrid.AllowUserToAddRows = false;
            this.bikeGrid.AllowUserToDeleteRows = false;
            this.bikeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bikeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bikeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bikeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bikeGrid.Location = new System.Drawing.Point(7, 124);
            this.bikeGrid.Name = "bikeGrid";
            this.bikeGrid.Size = new System.Drawing.Size(787, 320);
            this.bikeGrid.TabIndex = 2;
            // 
            // numRecordsLabel
            // 
            this.numRecordsLabel.Location = new System.Drawing.Point(320, 86);
            this.numRecordsLabel.Name = "numRecordsLabel";
            this.numRecordsLabel.Size = new System.Drawing.Size(199, 37);
            this.numRecordsLabel.TabIndex = 3;
            this.numRecordsLabel.Text = "# of Records";
            this.numRecordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 26);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // BikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.numRecordsLabel);
            this.Controls.Add(this.bikeGrid);
            this.Controls.Add(this.label1);
            this.Name = "BikeForm";
            this.Text = "Bikes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BikeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bikeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bikeGrid;
        private System.Windows.Forms.Label numRecordsLabel;
        private System.Windows.Forms.Button backButton;
    }
}