namespace SolarBudgetPlanner
{
    partial class mainForm
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.currentProfile = new System.Windows.Forms.Button();
            this.btnAboutTheApp = new System.Windows.Forms.Button();
            this.btnBgtOverview = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.btnBgtIncomes = new System.Windows.Forms.Button();
            this.btnBgtOutcomes = new System.Windows.Forms.Button();
            this.btnExpandMenu = new System.Windows.Forms.Button();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlMainMenu.Controls.Add(this.btnBgtOutcomes);
            this.pnlMainMenu.Controls.Add(this.btnBgtIncomes);
            this.pnlMainMenu.Controls.Add(this.btnBgtOverview);
            this.pnlMainMenu.Controls.Add(this.btnProfiles);
            this.pnlMainMenu.Controls.Add(this.btnAboutTheApp);
            this.pnlMainMenu.Controls.Add(this.currentProfile);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(200, 753);
            this.pnlMainMenu.TabIndex = 0;
            this.pnlMainMenu.Visible = false;
            // 
            // currentProfile
            // 
            this.currentProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.currentProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentProfile.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentProfile.Location = new System.Drawing.Point(0, 0);
            this.currentProfile.Margin = new System.Windows.Forms.Padding(0);
            this.currentProfile.Name = "currentProfile";
            this.currentProfile.Size = new System.Drawing.Size(200, 40);
            this.currentProfile.TabIndex = 0;
            this.currentProfile.Text = "Current Profile";
            this.currentProfile.UseVisualStyleBackColor = false;
            // 
            // btnAboutTheApp
            // 
            this.btnAboutTheApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAboutTheApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutTheApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAboutTheApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutTheApp.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutTheApp.Location = new System.Drawing.Point(0, 40);
            this.btnAboutTheApp.Margin = new System.Windows.Forms.Padding(0);
            this.btnAboutTheApp.Name = "btnAboutTheApp";
            this.btnAboutTheApp.Size = new System.Drawing.Size(200, 40);
            this.btnAboutTheApp.TabIndex = 1;
            this.btnAboutTheApp.Text = "About the App";
            this.btnAboutTheApp.UseVisualStyleBackColor = false;
            // 
            // btnBgtOverview
            // 
            this.btnBgtOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBgtOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBgtOverview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBgtOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBgtOverview.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBgtOverview.Location = new System.Drawing.Point(0, 120);
            this.btnBgtOverview.Margin = new System.Windows.Forms.Padding(0);
            this.btnBgtOverview.Name = "btnBgtOverview";
            this.btnBgtOverview.Size = new System.Drawing.Size(200, 40);
            this.btnBgtOverview.TabIndex = 3;
            this.btnBgtOverview.Text = "Budget Overview";
            this.btnBgtOverview.UseVisualStyleBackColor = false;
            // 
            // btnProfiles
            // 
            this.btnProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnProfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfiles.Location = new System.Drawing.Point(0, 80);
            this.btnProfiles.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(200, 40);
            this.btnProfiles.TabIndex = 2;
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.UseVisualStyleBackColor = false;
            // 
            // btnBgtIncomes
            // 
            this.btnBgtIncomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBgtIncomes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBgtIncomes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBgtIncomes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBgtIncomes.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBgtIncomes.Location = new System.Drawing.Point(0, 160);
            this.btnBgtIncomes.Margin = new System.Windows.Forms.Padding(0);
            this.btnBgtIncomes.Name = "btnBgtIncomes";
            this.btnBgtIncomes.Size = new System.Drawing.Size(200, 40);
            this.btnBgtIncomes.TabIndex = 4;
            this.btnBgtIncomes.Text = "Incomes";
            this.btnBgtIncomes.UseVisualStyleBackColor = false;
            // 
            // btnBgtOutcomes
            // 
            this.btnBgtOutcomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBgtOutcomes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBgtOutcomes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBgtOutcomes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBgtOutcomes.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBgtOutcomes.Location = new System.Drawing.Point(0, 200);
            this.btnBgtOutcomes.Margin = new System.Windows.Forms.Padding(0);
            this.btnBgtOutcomes.Name = "btnBgtOutcomes";
            this.btnBgtOutcomes.Size = new System.Drawing.Size(200, 40);
            this.btnBgtOutcomes.TabIndex = 5;
            this.btnBgtOutcomes.Text = "Outcomes";
            this.btnBgtOutcomes.UseVisualStyleBackColor = false;
            // 
            // btnExpandMenu
            // 
            this.btnExpandMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExpandMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpandMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExpandMenu.Location = new System.Drawing.Point(200, 0);
            this.btnExpandMenu.Name = "btnExpandMenu";
            this.btnExpandMenu.Size = new System.Drawing.Size(20, 753);
            this.btnExpandMenu.TabIndex = 1;
            this.btnExpandMenu.Text = ">";
            this.btnExpandMenu.UseVisualStyleBackColor = true;
            this.btnExpandMenu.Click += new System.EventHandler(this.BtnExpandMenu_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnExpandMenu);
            this.Controls.Add(this.pnlMainMenu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solar Budget Planner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button currentProfile;
        private System.Windows.Forms.Button btnAboutTheApp;
        private System.Windows.Forms.Button btnBgtOutcomes;
        private System.Windows.Forms.Button btnBgtIncomes;
        private System.Windows.Forms.Button btnBgtOverview;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.Button btnExpandMenu;
    }
}

