
namespace DBMidProject
{
    partial class CLOForm
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
            this.CLODataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDeleteCLO = new System.Windows.Forms.Button();
            this.buttonUpdateCLO = new System.Windows.Forms.Button();
            this.buttonAddCLO = new System.Windows.Forms.Button();
            this.txtCLOName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CLODataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLO\'S DATA TABLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CLODataGridView
            // 
            this.CLODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CLODataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.CLODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLODataGridView.Location = new System.Drawing.Point(361, 114);
            this.CLODataGridView.Name = "CLODataGridView";
            this.CLODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CLODataGridView.Size = new System.Drawing.Size(550, 277);
            this.CLODataGridView.TabIndex = 18;
            this.CLODataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLODataGridView_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "CLO Name";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonReset.Location = new System.Drawing.Point(140, 298);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 37);
            this.buttonReset.TabIndex = 25;
            this.buttonReset.Text = "RESET Fields";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDeleteCLO
            // 
            this.buttonDeleteCLO.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonDeleteCLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCLO.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDeleteCLO.Location = new System.Drawing.Point(30, 298);
            this.buttonDeleteCLO.Name = "buttonDeleteCLO";
            this.buttonDeleteCLO.Size = new System.Drawing.Size(90, 37);
            this.buttonDeleteCLO.TabIndex = 24;
            this.buttonDeleteCLO.Text = "DELETE";
            this.buttonDeleteCLO.UseVisualStyleBackColor = false;
            this.buttonDeleteCLO.Click += new System.EventHandler(this.buttonDeleteCLO_Click);
            // 
            // buttonUpdateCLO
            // 
            this.buttonUpdateCLO.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonUpdateCLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCLO.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonUpdateCLO.Location = new System.Drawing.Point(140, 233);
            this.buttonUpdateCLO.Name = "buttonUpdateCLO";
            this.buttonUpdateCLO.Size = new System.Drawing.Size(90, 37);
            this.buttonUpdateCLO.TabIndex = 23;
            this.buttonUpdateCLO.Text = "UPDATE";
            this.buttonUpdateCLO.UseVisualStyleBackColor = false;
            this.buttonUpdateCLO.Click += new System.EventHandler(this.buttonUpdateCLO_Click);
            // 
            // buttonAddCLO
            // 
            this.buttonAddCLO.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonAddCLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCLO.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAddCLO.Location = new System.Drawing.Point(29, 233);
            this.buttonAddCLO.Name = "buttonAddCLO";
            this.buttonAddCLO.Size = new System.Drawing.Size(91, 37);
            this.buttonAddCLO.TabIndex = 22;
            this.buttonAddCLO.Text = "INSERT";
            this.buttonAddCLO.UseVisualStyleBackColor = false;
            this.buttonAddCLO.Click += new System.EventHandler(this.buttonAddCLO_Click);
            // 
            // txtCLOName
            // 
            this.txtCLOName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLOName.Location = new System.Drawing.Point(29, 135);
            this.txtCLOName.Name = "txtCLOName";
            this.txtCLOName.Size = new System.Drawing.Size(201, 24);
            this.txtCLOName.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.txtCLOName);
            this.panel1.Controls.Add(this.buttonDeleteCLO);
            this.panel1.Controls.Add(this.buttonAddCLO);
            this.panel1.Controls.Add(this.buttonUpdateCLO);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 597);
            this.panel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(88, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CLOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(992, 476);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CLODataGridView);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CLOForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLOForm";
            this.Load += new System.EventHandler(this.CLOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLODataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CLODataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDeleteCLO;
        private System.Windows.Forms.Button buttonUpdateCLO;
        private System.Windows.Forms.Button buttonAddCLO;
        private System.Windows.Forms.TextBox txtCLOName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}