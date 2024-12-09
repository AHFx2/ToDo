namespace ToDo
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelegate = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminate = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDo = new Guna.UI2.WinForms.Guna2Button();
            this.btnMimuize = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMaxmuize = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMimuize);
            this.panel1.Controls.Add(this.btnMaxmuize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 33);
            this.panel1.TabIndex = 3;
            // 
            // btnDelegate
            // 
            this.btnDelegate.BorderRadius = 10;
            this.btnDelegate.CheckedState.Parent = this.btnDelegate;
            this.btnDelegate.CustomImages.Parent = this.btnDelegate;
            this.btnDelegate.FillColor = System.Drawing.Color.DarkTurquoise;
            this.btnDelegate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnDelegate.ForeColor = System.Drawing.Color.White;
            this.btnDelegate.HoverState.Parent = this.btnDelegate;
            this.btnDelegate.Image = global::ToDo.Properties.Resources.icons8_delegate_100;
            this.btnDelegate.ImageSize = new System.Drawing.Size(100, 100);
            this.btnDelegate.Location = new System.Drawing.Point(166, 375);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.ShadowDecoration.Parent = this.btnDelegate;
            this.btnDelegate.Size = new System.Drawing.Size(300, 300);
            this.btnDelegate.TabIndex = 4;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnEliminate
            // 
            this.btnEliminate.BorderRadius = 10;
            this.btnEliminate.CheckedState.Parent = this.btnEliminate;
            this.btnEliminate.CustomImages.Parent = this.btnEliminate;
            this.btnEliminate.FillColor = System.Drawing.Color.Red;
            this.btnEliminate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnEliminate.ForeColor = System.Drawing.Color.White;
            this.btnEliminate.HoverState.Parent = this.btnEliminate;
            this.btnEliminate.Image = global::ToDo.Properties.Resources.icons8_trush_100;
            this.btnEliminate.ImageSize = new System.Drawing.Size(100, 100);
            this.btnEliminate.Location = new System.Drawing.Point(504, 375);
            this.btnEliminate.Name = "btnEliminate";
            this.btnEliminate.ShadowDecoration.Parent = this.btnEliminate;
            this.btnEliminate.Size = new System.Drawing.Size(300, 300);
            this.btnEliminate.TabIndex = 4;
            this.btnEliminate.Text = "Eliminate";
            this.btnEliminate.Click += new System.EventHandler(this.btnEliminate_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.BorderRadius = 10;
            this.btnPlan.CheckedState.Parent = this.btnPlan;
            this.btnPlan.CustomImages.Parent = this.btnPlan;
            this.btnPlan.FillColor = System.Drawing.Color.Chocolate;
            this.btnPlan.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPlan.ForeColor = System.Drawing.Color.White;
            this.btnPlan.HoverState.Parent = this.btnPlan;
            this.btnPlan.Image = global::ToDo.Properties.Resources.Plan100;
            this.btnPlan.ImageSize = new System.Drawing.Size(100, 100);
            this.btnPlan.Location = new System.Drawing.Point(504, 48);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.ShadowDecoration.Parent = this.btnPlan;
            this.btnPlan.Size = new System.Drawing.Size(300, 300);
            this.btnPlan.TabIndex = 4;
            this.btnPlan.Text = "Plan";
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnDo
            // 
            this.btnDo.BorderRadius = 10;
            this.btnDo.CheckedState.Parent = this.btnDo;
            this.btnDo.CustomImages.Parent = this.btnDo;
            this.btnDo.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnDo.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnDo.ForeColor = System.Drawing.Color.White;
            this.btnDo.HoverState.Parent = this.btnDo;
            this.btnDo.Image = global::ToDo.Properties.Resources.icons8_urgent_property_100__2_;
            this.btnDo.ImageSize = new System.Drawing.Size(100, 100);
            this.btnDo.Location = new System.Drawing.Point(166, 48);
            this.btnDo.Name = "btnDo";
            this.btnDo.ShadowDecoration.Parent = this.btnDo;
            this.btnDo.Size = new System.Drawing.Size(300, 300);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "Do";
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnMimuize
            // 
            this.btnMimuize.CheckedState.Parent = this.btnMimuize;
            this.btnMimuize.CustomImages.Parent = this.btnMimuize;
            this.btnMimuize.FillColor = System.Drawing.Color.Transparent;
            this.btnMimuize.FillColor2 = System.Drawing.Color.Transparent;
            this.btnMimuize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMimuize.ForeColor = System.Drawing.Color.White;
            this.btnMimuize.HoverState.Parent = this.btnMimuize;
            this.btnMimuize.Image = global::ToDo.Properties.Resources.minus;
            this.btnMimuize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMimuize.Location = new System.Drawing.Point(840, 4);
            this.btnMimuize.Name = "btnMimuize";
            this.btnMimuize.ShadowDecoration.Parent = this.btnMimuize;
            this.btnMimuize.Size = new System.Drawing.Size(25, 25);
            this.btnMimuize.TabIndex = 4;
            // 
            // btnMaxmuize
            // 
            this.btnMaxmuize.CheckedState.Parent = this.btnMaxmuize;
            this.btnMaxmuize.CustomImages.Parent = this.btnMaxmuize;
            this.btnMaxmuize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaxmuize.FillColor2 = System.Drawing.Color.Transparent;
            this.btnMaxmuize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaxmuize.ForeColor = System.Drawing.Color.White;
            this.btnMaxmuize.HoverState.Parent = this.btnMaxmuize;
            this.btnMaxmuize.Image = global::ToDo.Properties.Resources.maximize_size;
            this.btnMaxmuize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMaxmuize.Location = new System.Drawing.Point(901, 4);
            this.btnMaxmuize.Name = "btnMaxmuize";
            this.btnMaxmuize.ShadowDecoration.Parent = this.btnMaxmuize;
            this.btnMaxmuize.Size = new System.Drawing.Size(25, 25);
            this.btnMaxmuize.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.FillColor2 = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = global::ToDo.Properties.Resources.cross__1_;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(962, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(990, 703);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.btnEliminate);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnMimuize;
        private Guna.UI2.WinForms.Guna2GradientButton btnMaxmuize;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnDelegate;
        private Guna.UI2.WinForms.Guna2Button btnEliminate;
        private Guna.UI2.WinForms.Guna2Button btnPlan;
        private Guna.UI2.WinForms.Guna2Button btnDo;
    }
}

