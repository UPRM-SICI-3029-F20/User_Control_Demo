
namespace User_Control_Demo
{
    partial class UserControl_Inventory
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.Btn_SaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUnits = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvInventory.Location = new System.Drawing.Point(32, 28);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(541, 223);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            this.dgvInventory.SelectionChanged += new System.EventHandler(this.dgvInventory_SelectionChanged);
            // 
            // Btn_SaveChanges
            // 
            this.Btn_SaveChanges.Location = new System.Drawing.Point(15, 403);
            this.Btn_SaveChanges.Name = "Btn_SaveChanges";
            this.Btn_SaveChanges.Size = new System.Drawing.Size(119, 23);
            this.Btn_SaveChanges.TabIndex = 1;
            this.Btn_SaveChanges.Text = "Save Changes to File";
            this.Btn_SaveChanges.UseVisualStyleBackColor = true;
            this.Btn_SaveChanges.Click += new System.EventHandler(this.Btn_SaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select  the cell you wish to edit (units).";
            // 
            // txtBoxUnits
            // 
            this.txtBoxUnits.Location = new System.Drawing.Point(160, 296);
            this.txtBoxUnits.Name = "txtBoxUnits";
            this.txtBoxUnits.Size = new System.Drawing.Size(184, 20);
            this.txtBoxUnits.TabIndex = 3;
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Update.Location = new System.Drawing.Point(350, 290);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(127, 31);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "Validate and Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Validate_and_Update);
            // 
            // UserControl_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.txtBoxUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_SaveChanges);
            this.Controls.Add(this.dgvInventory);
            this.Name = "UserControl_Inventory";
            this.Size = new System.Drawing.Size(614, 440);
            this.Load += new System.EventHandler(this.UserControl_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button Btn_SaveChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUnits;
        private System.Windows.Forms.Button Btn_Update;
    }
}
