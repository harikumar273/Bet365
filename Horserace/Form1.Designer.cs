namespace Horserace
{
    partial class Form1
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
            this.HorseName = new System.Windows.Forms.Label();
            this.TxtHorseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOdd1 = new System.Windows.Forms.TextBox();
            this.Odd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOdd2 = new System.Windows.Forms.TextBox();
            this.BtnAddHorseToRace = new System.Windows.Forms.Button();
            this.BrnRunRace = new System.Windows.Forms.Button();
            this.TxtRaceWinner = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Odds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanceOfWinningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HorseName
            // 
            this.HorseName.AutoSize = true;
            this.HorseName.Location = new System.Drawing.Point(50, 52);
            this.HorseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HorseName.Name = "HorseName";
            this.HorseName.Size = new System.Drawing.Size(66, 13);
            this.HorseName.TabIndex = 0;
            this.HorseName.Text = "Horse Name";
            // 
            // TxtHorseName
            // 
            this.TxtHorseName.Location = new System.Drawing.Point(147, 52);
            this.TxtHorseName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHorseName.Name = "TxtHorseName";
            this.TxtHorseName.Size = new System.Drawing.Size(315, 20);
            this.TxtHorseName.TabIndex = 1;
            this.TxtHorseName.TextChanged += new System.EventHandler(this.TxtHorseName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Virtual Horse Simulator";
            // 
            // TxtOdd1
            // 
            this.TxtOdd1.Location = new System.Drawing.Point(147, 88);
            this.TxtOdd1.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOdd1.Name = "TxtOdd1";
            this.TxtOdd1.Size = new System.Drawing.Size(36, 20);
            this.TxtOdd1.TabIndex = 4;
            this.TxtOdd1.TextChanged += new System.EventHandler(this.TxtOdd1_TextChanged);
            // 
            // Odd
            // 
            this.Odd.AutoSize = true;
            this.Odd.Location = new System.Drawing.Point(50, 88);
            this.Odd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Odd.Name = "Odd";
            this.Odd.Size = new System.Drawing.Size(32, 13);
            this.Odd.TabIndex = 3;
            this.Odd.Text = "Odds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // TxtOdd2
            // 
            this.TxtOdd2.Location = new System.Drawing.Point(205, 91);
            this.TxtOdd2.Margin = new System.Windows.Forms.Padding(2);
            this.TxtOdd2.Name = "TxtOdd2";
            this.TxtOdd2.Size = new System.Drawing.Size(36, 20);
            this.TxtOdd2.TabIndex = 6;
            this.TxtOdd2.TextChanged += new System.EventHandler(this.TxtOdd2_TextChanged);
            // 
            // BtnAddHorseToRace
            // 
            this.BtnAddHorseToRace.Location = new System.Drawing.Point(262, 91);
            this.BtnAddHorseToRace.Name = "BtnAddHorseToRace";
            this.BtnAddHorseToRace.Size = new System.Drawing.Size(75, 23);
            this.BtnAddHorseToRace.TabIndex = 7;
            this.BtnAddHorseToRace.Text = "Add Horse";
            this.BtnAddHorseToRace.UseVisualStyleBackColor = true;
            this.BtnAddHorseToRace.Click += new System.EventHandler(this.BtnAddHorseToRace_Click);
            // 
            // BrnRunRace
            // 
            this.BrnRunRace.Location = new System.Drawing.Point(41, 593);
            this.BrnRunRace.Name = "BrnRunRace";
            this.BrnRunRace.Size = new System.Drawing.Size(75, 23);
            this.BrnRunRace.TabIndex = 8;
            this.BrnRunRace.Text = "Run Race";
            this.BrnRunRace.UseVisualStyleBackColor = true;
            this.BrnRunRace.Click += new System.EventHandler(this.BrnRunRace_Click);
            // 
            // TxtRaceWinner
            // 
            this.TxtRaceWinner.AutoSize = true;
            this.TxtRaceWinner.Location = new System.Drawing.Point(159, 593);
            this.TxtRaceWinner.Name = "TxtRaceWinner";
            this.TxtRaceWinner.Size = new System.Drawing.Size(0, 13);
            this.TxtRaceWinner.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horseNameDataGridViewTextBoxColumn,
            this.Odds,
            this.oddDataGridViewTextBoxColumn,
            this.marginDataGridViewTextBoxColumn,
            this.chanceOfWinningDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.horseBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 458);
            this.dataGridView1.TabIndex = 10;
            // 
            // Odds
            // 
            this.Odds.DataPropertyName = "Odds";
            this.Odds.HeaderText = "Odds";
            this.Odds.Name = "Odds";
            // 
            // horseNameDataGridViewTextBoxColumn
            // 
            this.horseNameDataGridViewTextBoxColumn.DataPropertyName = "HorseName";
            this.horseNameDataGridViewTextBoxColumn.HeaderText = "HorseName";
            this.horseNameDataGridViewTextBoxColumn.Name = "horseNameDataGridViewTextBoxColumn";
            // 
            // oddDataGridViewTextBoxColumn
            // 
            this.oddDataGridViewTextBoxColumn.DataPropertyName = "Odd";
            this.oddDataGridViewTextBoxColumn.HeaderText = "Odd";
            this.oddDataGridViewTextBoxColumn.Name = "oddDataGridViewTextBoxColumn";
            this.oddDataGridViewTextBoxColumn.Visible = false;
            // 
            // marginDataGridViewTextBoxColumn
            // 
            this.marginDataGridViewTextBoxColumn.DataPropertyName = "Margin";
            this.marginDataGridViewTextBoxColumn.HeaderText = "Margin";
            this.marginDataGridViewTextBoxColumn.Name = "marginDataGridViewTextBoxColumn";
            this.marginDataGridViewTextBoxColumn.ReadOnly = true;
            this.marginDataGridViewTextBoxColumn.Visible = false;
            // 
            // chanceOfWinningDataGridViewTextBoxColumn
            // 
            this.chanceOfWinningDataGridViewTextBoxColumn.DataPropertyName = "ChanceOfWinning";
            this.chanceOfWinningDataGridViewTextBoxColumn.HeaderText = "ChanceOfWinning";
            this.chanceOfWinningDataGridViewTextBoxColumn.Name = "chanceOfWinningDataGridViewTextBoxColumn";
            this.chanceOfWinningDataGridViewTextBoxColumn.Visible = false;
            // 
            // horseBindingSource
            // 
            this.horseBindingSource.DataSource = typeof(Horserace.Core.Horse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 687);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtRaceWinner);
            this.Controls.Add(this.BrnRunRace);
            this.Controls.Add(this.BtnAddHorseToRace);
            this.Controls.Add(this.TxtOdd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOdd1);
            this.Controls.Add(this.Odd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHorseName);
            this.Controls.Add(this.HorseName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HorseName;
        private System.Windows.Forms.TextBox TxtHorseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOdd1;
        private System.Windows.Forms.Label Odd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOdd2;
        private System.Windows.Forms.Button BtnAddHorseToRace;
        private System.Windows.Forms.Button BrnRunRace;
        private System.Windows.Forms.Label TxtRaceWinner;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource horseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn horseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odds;
        private System.Windows.Forms.DataGridViewTextBoxColumn oddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanceOfWinningDataGridViewTextBoxColumn;
    }
}

