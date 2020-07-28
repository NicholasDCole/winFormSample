namespace ColeProject4
{
    partial class ComponentForm
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
            this.componentGrid = new System.Windows.Forms.DataGridView();
            this.componentLabel = new System.Windows.Forms.Label();
            this.numRecordsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.componentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // componentGrid
            // 
            this.componentGrid.AllowUserToAddRows = false;
            this.componentGrid.AllowUserToDeleteRows = false;
            this.componentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.componentGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.componentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentGrid.Location = new System.Drawing.Point(7, 126);
            this.componentGrid.Name = "componentGrid";
            this.componentGrid.Size = new System.Drawing.Size(787, 320);
            this.componentGrid.TabIndex = 5;
            // 
            // componentLabel
            // 
            this.componentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.componentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentLabel.Location = new System.Drawing.Point(320, 9);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(199, 37);
            this.componentLabel.TabIndex = 4;
            this.componentLabel.Text = "Components";
            this.componentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.numRecordsLabel.TabIndex = 10;
            this.numRecordsLabel.Text = "# of Records";
            this.numRecordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(7, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 26);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.numRecordsLabel);
            this.Controls.Add(this.componentGrid);
            this.Controls.Add(this.componentLabel);
            this.Name = "ComponentForm";
            this.Text = "Components";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComponentForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.componentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView componentGrid;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label numRecordsLabel;
        private System.Windows.Forms.Button backButton;
    }
}