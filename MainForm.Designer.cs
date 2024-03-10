
namespace DBMidProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stdbtn = new System.Windows.Forms.Button();
            this.assbtn = new System.Windows.Forms.Button();
            this.clobtn = new System.Windows.Forms.Button();
            this.rubbtn = new System.Windows.Forms.Button();
            this.lvlbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stdbtn
            // 
            this.stdbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.stdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdbtn.Location = new System.Drawing.Point(52, 80);
            this.stdbtn.Name = "stdbtn";
            this.stdbtn.Size = new System.Drawing.Size(206, 40);
            this.stdbtn.TabIndex = 0;
            this.stdbtn.Text = "Manage Student";
            this.stdbtn.UseVisualStyleBackColor = false;
            this.stdbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // assbtn
            // 
            this.assbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.assbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assbtn.Location = new System.Drawing.Point(52, 150);
            this.assbtn.Name = "assbtn";
            this.assbtn.Size = new System.Drawing.Size(206, 40);
            this.assbtn.TabIndex = 1;
            this.assbtn.Text = "Manage Assessment";
            this.assbtn.UseVisualStyleBackColor = false;
            this.assbtn.Click += new System.EventHandler(this.assbtn_Click);
            // 
            // clobtn
            // 
            this.clobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clobtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.clobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clobtn.Location = new System.Drawing.Point(52, 220);
            this.clobtn.Name = "clobtn";
            this.clobtn.Size = new System.Drawing.Size(206, 40);
            this.clobtn.TabIndex = 2;
            this.clobtn.Text = "Manage CLO";
            this.clobtn.UseVisualStyleBackColor = false;
            this.clobtn.Click += new System.EventHandler(this.clobtn_Click);
            // 
            // rubbtn
            // 
            this.rubbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.rubbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubbtn.Location = new System.Drawing.Point(52, 295);
            this.rubbtn.Name = "rubbtn";
            this.rubbtn.Size = new System.Drawing.Size(206, 40);
            this.rubbtn.TabIndex = 3;
            this.rubbtn.Text = "Manage Rubric";
            this.rubbtn.UseVisualStyleBackColor = false;
            this.rubbtn.Click += new System.EventHandler(this.rubbtn_Click);
            // 
            // lvlbtn
            // 
            this.lvlbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lvlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlbtn.Location = new System.Drawing.Point(52, 365);
            this.lvlbtn.Name = "lvlbtn";
            this.lvlbtn.Size = new System.Drawing.Size(206, 40);
            this.lvlbtn.TabIndex = 4;
            this.lvlbtn.Text = "Manage Rubric Level";
            this.lvlbtn.UseVisualStyleBackColor = false;
            this.lvlbtn.Click += new System.EventHandler(this.lvlbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.lvlbtn);
            this.panel1.Controls.Add(this.stdbtn);
            this.panel1.Controls.Add(this.rubbtn);
            this.panel1.Controls.Add(this.assbtn);
            this.panel1.Controls.Add(this.clobtn);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 478);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(926, 482);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stdbtn;
        private System.Windows.Forms.Button assbtn;
        private System.Windows.Forms.Button clobtn;
        private System.Windows.Forms.Button rubbtn;
        private System.Windows.Forms.Button lvlbtn;
        private System.Windows.Forms.Panel panel1;
    }
}