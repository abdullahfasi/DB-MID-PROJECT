
namespace DBMidProject
{
    partial class RubricCRUDForm
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
            this.RubricDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRubricDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCLO = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDeleteRubric = new System.Windows.Forms.Button();
            this.buttonUpdateRubric = new System.Windows.Forms.Button();
            this.buttonAddRubric = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRubricID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RubricDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RubricDataGridView
            // 
            this.RubricDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.RubricDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RubricDataGridView.Location = new System.Drawing.Point(431, 110);
            this.RubricDataGridView.Name = "RubricDataGridView";
            this.RubricDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RubricDataGridView.Size = new System.Drawing.Size(513, 266);
            this.RubricDataGridView.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(548, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rubrics Data Table\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRubricDetails
            // 
            this.txtRubricDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubricDetails.Location = new System.Drawing.Point(34, 176);
            this.txtRubricDetails.Multiline = true;
            this.txtRubricDetails.Name = "txtRubricDetails";
            this.txtRubricDetails.Size = new System.Drawing.Size(219, 50);
            this.txtRubricDetails.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Rubric Details";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "CLO ID";
            // 
            // cmbCLO
            // 
            this.cmbCLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCLO.FormattingEnabled = true;
            this.cmbCLO.Location = new System.Drawing.Point(34, 263);
            this.cmbCLO.Name = "cmbCLO";
            this.cmbCLO.Size = new System.Drawing.Size(219, 28);
            this.cmbCLO.TabIndex = 30;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonReset.Location = new System.Drawing.Point(158, 382);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 37);
            this.buttonReset.TabIndex = 34;
            this.buttonReset.Text = "RESET Fields";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDeleteRubric
            // 
            this.buttonDeleteRubric.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonDeleteRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRubric.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDeleteRubric.Location = new System.Drawing.Point(34, 382);
            this.buttonDeleteRubric.Name = "buttonDeleteRubric";
            this.buttonDeleteRubric.Size = new System.Drawing.Size(95, 37);
            this.buttonDeleteRubric.TabIndex = 33;
            this.buttonDeleteRubric.Text = "DELETE";
            this.buttonDeleteRubric.UseVisualStyleBackColor = false;
            this.buttonDeleteRubric.Click += new System.EventHandler(this.buttonDeleteRubric_Click);
            // 
            // buttonUpdateRubric
            // 
            this.buttonUpdateRubric.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonUpdateRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRubric.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonUpdateRubric.Location = new System.Drawing.Point(158, 326);
            this.buttonUpdateRubric.Name = "buttonUpdateRubric";
            this.buttonUpdateRubric.Size = new System.Drawing.Size(95, 37);
            this.buttonUpdateRubric.TabIndex = 32;
            this.buttonUpdateRubric.Text = "UPDATE";
            this.buttonUpdateRubric.UseVisualStyleBackColor = false;
            this.buttonUpdateRubric.Click += new System.EventHandler(this.buttonUpdateRubric_Click);
            // 
            // buttonAddRubric
            // 
            this.buttonAddRubric.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonAddRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRubric.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAddRubric.Location = new System.Drawing.Point(34, 326);
            this.buttonAddRubric.Name = "buttonAddRubric";
            this.buttonAddRubric.Size = new System.Drawing.Size(95, 37);
            this.buttonAddRubric.TabIndex = 31;
            this.buttonAddRubric.Text = "INSERT";
            this.buttonAddRubric.UseVisualStyleBackColor = false;
            this.buttonAddRubric.Click += new System.EventHandler(this.buttonAddRubric_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Rubric ID";
            // 
            // txtRubricID
            // 
            this.txtRubricID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubricID.Location = new System.Drawing.Point(34, 112);
            this.txtRubricID.Name = "txtRubricID";
            this.txtRubricID.Size = new System.Drawing.Size(219, 24);
            this.txtRubricID.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.txtRubricID);
            this.panel1.Controls.Add(this.buttonDeleteRubric);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonUpdateRubric);
            this.panel1.Controls.Add(this.txtRubricDetails);
            this.panel1.Controls.Add(this.buttonAddRubric);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCLO);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 590);
            this.panel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InfoText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(71, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RubricCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(999, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RubricDataGridView);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RubricCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RubricCRUDForm";
            this.Load += new System.EventHandler(this.RubricCRUDForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.RubricDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RubricDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRubricDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCLO;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDeleteRubric;
        private System.Windows.Forms.Button buttonUpdateRubric;
        private System.Windows.Forms.Button buttonAddRubric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRubricID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}