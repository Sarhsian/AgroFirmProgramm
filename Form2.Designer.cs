namespace AgroFirmProgramm
{
    partial class Form2
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
            this.btnClients = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(274, 738);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(129, 80);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(409, 738);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(117, 80);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.Location = new System.Drawing.Point(140, 738);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(128, 80);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "Workers";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin Menu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 738);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 681);
            this.dataGridView1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1253, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 80);
            this.button5.TabIndex = 6;
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1253, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 80);
            this.button6.TabIndex = 7;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1253, 223);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(167, 80);
            this.button8.TabIndex = 9;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 830);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWorkers);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnClients);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}