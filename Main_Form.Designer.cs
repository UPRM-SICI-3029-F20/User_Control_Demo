
namespace User_Control_Demo
{
    partial class Main_Form
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
            this.Panel_Buttons = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Purple = new System.Windows.Forms.Button();
            this.Btn_Green = new System.Windows.Forms.Button();
            this.Btn_Inv = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Panel_User_Controls = new System.Windows.Forms.Panel();
            this.Label_Home = new System.Windows.Forms.Label();
            this.userControl_Purple1 = new User_Control_Demo.UserControl_Purple();
            this.userControl_Green1 = new User_Control_Demo.UserControl_Green();
            this.userControl_Inventory1 = new User_Control_Demo.UserControl_Inventory();
            this.Panel_Buttons.SuspendLayout();
            this.Panel_User_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Buttons
            // 
            this.Panel_Buttons.BackColor = System.Drawing.Color.Silver;
            this.Panel_Buttons.Controls.Add(this.Btn_Exit);
            this.Panel_Buttons.Controls.Add(this.Btn_Purple);
            this.Panel_Buttons.Controls.Add(this.Btn_Green);
            this.Panel_Buttons.Controls.Add(this.Btn_Inv);
            this.Panel_Buttons.Controls.Add(this.Btn_Home);
            this.Panel_Buttons.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Buttons.Location = new System.Drawing.Point(0, 0);
            this.Panel_Buttons.Name = "Panel_Buttons";
            this.Panel_Buttons.Size = new System.Drawing.Size(200, 471);
            this.Panel_Buttons.TabIndex = 0;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(51, 324);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Purple
            // 
            this.Btn_Purple.Location = new System.Drawing.Point(51, 230);
            this.Btn_Purple.Name = "Btn_Purple";
            this.Btn_Purple.Size = new System.Drawing.Size(75, 23);
            this.Btn_Purple.TabIndex = 3;
            this.Btn_Purple.Text = "Purple";
            this.Btn_Purple.UseVisualStyleBackColor = true;
            this.Btn_Purple.Click += new System.EventHandler(this.Btn_Purple_Click);
            // 
            // Btn_Green
            // 
            this.Btn_Green.Location = new System.Drawing.Point(51, 183);
            this.Btn_Green.Name = "Btn_Green";
            this.Btn_Green.Size = new System.Drawing.Size(75, 23);
            this.Btn_Green.TabIndex = 2;
            this.Btn_Green.Text = "Green";
            this.Btn_Green.UseVisualStyleBackColor = true;
            this.Btn_Green.Click += new System.EventHandler(this.Btn_Green_Click);
            // 
            // Btn_Inv
            // 
            this.Btn_Inv.Location = new System.Drawing.Point(51, 136);
            this.Btn_Inv.Name = "Btn_Inv";
            this.Btn_Inv.Size = new System.Drawing.Size(75, 23);
            this.Btn_Inv.TabIndex = 1;
            this.Btn_Inv.Text = "Inventory";
            this.Btn_Inv.UseVisualStyleBackColor = true;
            this.Btn_Inv.Click += new System.EventHandler(this.Btn_Inv_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.Location = new System.Drawing.Point(51, 89);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(75, 23);
            this.Btn_Home.TabIndex = 0;
            this.Btn_Home.Text = "Home";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Panel_User_Controls
            // 
            this.Panel_User_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel_User_Controls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_User_Controls.Controls.Add(this.Label_Home);
            this.Panel_User_Controls.Controls.Add(this.userControl_Purple1);
            this.Panel_User_Controls.Controls.Add(this.userControl_Green1);
            this.Panel_User_Controls.Controls.Add(this.userControl_Inventory1);
            this.Panel_User_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_User_Controls.Location = new System.Drawing.Point(200, 0);
            this.Panel_User_Controls.Name = "Panel_User_Controls";
            this.Panel_User_Controls.Size = new System.Drawing.Size(636, 471);
            this.Panel_User_Controls.TabIndex = 1;
            // 
            // Label_Home
            // 
            this.Label_Home.AutoSize = true;
            this.Label_Home.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Home.Location = new System.Drawing.Point(86, 216);
            this.Label_Home.Name = "Label_Home";
            this.Label_Home.Size = new System.Drawing.Size(467, 37);
            this.Label_Home.TabIndex = 3;
            this.Label_Home.Text = "DEMO - User Controls & DGV";
            // 
            // userControl_Purple1
            // 
            this.userControl_Purple1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userControl_Purple1.Location = new System.Drawing.Point(17, 14);
            this.userControl_Purple1.Name = "userControl_Purple1";
            this.userControl_Purple1.Size = new System.Drawing.Size(600, 440);
            this.userControl_Purple1.TabIndex = 2;
            // 
            // userControl_Green1
            // 
            this.userControl_Green1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userControl_Green1.Location = new System.Drawing.Point(17, 14);
            this.userControl_Green1.Name = "userControl_Green1";
            this.userControl_Green1.Size = new System.Drawing.Size(600, 440);
            this.userControl_Green1.TabIndex = 1;
            // 
            // userControl_Inventory1
            // 
            this.userControl_Inventory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userControl_Inventory1.Location = new System.Drawing.Point(17, 14);
            this.userControl_Inventory1.Name = "userControl_Inventory1";
            this.userControl_Inventory1.Size = new System.Drawing.Size(600, 440);
            this.userControl_Inventory1.TabIndex = 0;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 471);
            this.Controls.Add(this.Panel_User_Controls);
            this.Controls.Add(this.Panel_Buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Control - Read/Write Demo";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Panel_Buttons.ResumeLayout(false);
            this.Panel_User_Controls.ResumeLayout(false);
            this.Panel_User_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Buttons;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Purple;
        private System.Windows.Forms.Button Btn_Green;
        private System.Windows.Forms.Button Btn_Inv;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Panel Panel_User_Controls;
        private UserControl_Inventory userControl_Inventory1;
        private UserControl_Purple userControl_Purple1;
        private UserControl_Green userControl_Green1;
        private System.Windows.Forms.Label Label_Home;
    }
}

