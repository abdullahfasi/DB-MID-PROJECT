
namespace DBMidProject
{
    partial class AssessmentCRUDForm
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
            this.AssessmentDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalWeightage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDeleteRubric = new System.Windows.Forms.Button();
            this.buttonUpdateRubric = new System.Windows.Forms.Button();
            this.buttonAddRubric = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssessmentDataGridView
            // 
            this.AssessmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssessmentDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.AssessmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentDataGridView.Location = new System.Drawing.Point(417, 101);
            this.AssessmentDataGridView.Name = "AssessmentDataGridView";
            this.AssessmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssessmentDataGridView.Size = new System.Drawing.Size(569, 287);
            this.AssessmentDataGridView.TabIndex = 20;
            this.AssessmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssessmentDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student\'s Assessment Table";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(35, 105);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(201, 24);
            this.txtTitle.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Title";
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMarks.Location = new System.Drawing.Point(35, 171);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(201, 24);
            this.txtTotalMarks.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total Marks";
            // 
            // txtTotalWeightage
            // 
            this.txtTotalWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWeightage.Location = new System.Drawing.Point(35, 237);
            this.txtTotalWeightage.Name = "txtTotalWeightage";
            this.txtTotalWeightage.Size = new System.Drawing.Size(201, 24);
            this.txtTotalWeightage.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total Weightage";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonReset.Location = new System.Drawing.Point(142, 355);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 37);
            this.buttonReset.TabIndex = 36;
            this.buttonReset.Text = "RESET Fields";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDeleteRubric
            // 
            this.buttonDeleteRubric.BackColor = System.Drawing.Color.Black;
            this.buttonDeleteRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteRubric.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDeleteRubric.Location = new System.Drawing.Point(35, 355);
            this.buttonDeleteRubric.Name = "buttonDeleteRubric";
            this.buttonDeleteRubric.Size = new System.Drawing.Size(94, 37);
            this.buttonDeleteRubric.TabIndex = 35;
            this.buttonDeleteRubric.Text = "DELETE";
            this.buttonDeleteRubric.UseVisualStyleBackColor = false;
            this.buttonDeleteRubric.Click += new System.EventHandler(this.buttonDeleteRubric_Click);
            // 
            // buttonUpdateRubric
            // 
            this.buttonUpdateRubric.BackColor = System.Drawing.Color.Black;
            this.buttonUpdateRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRubric.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonUpdateRubric.Location = new System.Drawing.Point(142, 300);
            this.buttonUpdateRubric.Name = "buttonUpdateRubric";
            this.buttonUpdateRubric.Size = new System.Drawing.Size(94, 37);
            this.buttonUpdateRubric.TabIndex = 34;
            this.buttonUpdateRubric.Text = "UPDATE";
            this.buttonUpdateRubric.UseVisualStyleBackColor = false;
            this.buttonUpdateRubric.Click += new System.EventHandler(this.buttonUpdateRubric_Click);
            // 
            // buttonAddRubric
            // 
            this.buttonAddRubric.BackColor = System.Drawing.Color.Black;
            this.buttonAddRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRubric.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAddRubric.Location = new System.Drawing.Point(35, 300);
            this.buttonAddRubric.Name = "buttonAddRubric";
            this.buttonAddRubric.Size = new System.Drawing.Size(94, 37);
            this.buttonAddRubric.TabIndex = 33;
            this.buttonAddRubric.Text = "INSERT";
            this.buttonAddRubric.UseVisualStyleBackColor = false;
            this.buttonAddRubric.Click += new System.EventHandler(this.buttonAddRubric_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.buttonDeleteRubric);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonUpdateRubric);
            this.panel1.Controls.Add(this.txtTotalMarks);
            this.panel1.Controls.Add(this.buttonAddRubric);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalWeightage);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 590);
            this.panel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(90, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssessmentCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1078, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AssessmentDataGridView);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssessmentCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssessmentCRUDForm";
            this.Load += new System.EventHandler(this.AssessmentCRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AssessmentDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalWeightage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDeleteRubric;
        private System.Windows.Forms.Button buttonUpdateRubric;
        private System.Windows.Forms.Button buttonAddRubric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}