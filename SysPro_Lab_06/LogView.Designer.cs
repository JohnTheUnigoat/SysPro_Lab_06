﻿namespace SysPro_Lab_06
{
    partial class LogView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btIncrementDate = new System.Windows.Forms.Button();
            this.btDecrementDate = new System.Windows.Forms.Button();
            this.tbSelectedDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.trbSelectedDate = new System.Windows.Forms.TrackBar();
            this.tbRoomsOccupied = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHolidayPeriods = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSelectedDate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvRooms);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 306);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rooms";
            // 
            // dgvRooms
            // 
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(6, 21);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.Size = new System.Drawing.Size(487, 279);
            this.dgvRooms.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btIncrementDate);
            this.groupBox2.Controls.Add(this.btDecrementDate);
            this.groupBox2.Controls.Add(this.tbSelectedDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblEndDate);
            this.groupBox2.Controls.Add(this.lblStartDate);
            this.groupBox2.Controls.Add(this.trbSelectedDate);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timeline";
            // 
            // btIncrementDate
            // 
            this.btIncrementDate.Location = new System.Drawing.Point(313, 15);
            this.btIncrementDate.Name = "btIncrementDate";
            this.btIncrementDate.Size = new System.Drawing.Size(21, 20);
            this.btIncrementDate.TabIndex = 6;
            this.btIncrementDate.Text = ">";
            this.btIncrementDate.UseVisualStyleBackColor = true;
            // 
            // btDecrementDate
            // 
            this.btDecrementDate.Location = new System.Drawing.Point(212, 15);
            this.btDecrementDate.Name = "btDecrementDate";
            this.btDecrementDate.Size = new System.Drawing.Size(21, 20);
            this.btDecrementDate.TabIndex = 5;
            this.btDecrementDate.Text = "<";
            this.btDecrementDate.UseVisualStyleBackColor = true;
            // 
            // tbSelectedDate
            // 
            this.tbSelectedDate.Location = new System.Drawing.Point(239, 15);
            this.tbSelectedDate.Name = "tbSelectedDate";
            this.tbSelectedDate.ReadOnly = true;
            this.tbSelectedDate.Size = new System.Drawing.Size(68, 20);
            this.tbSelectedDate.TabIndex = 4;
            this.tbSelectedDate.Text = "01/01/1970";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selected date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(422, 33);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(65, 13);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "01/01/1970";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(6, 33);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(65, 13);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "01/01/1970";
            // 
            // trbSelectedDate
            // 
            this.trbSelectedDate.LargeChange = 1;
            this.trbSelectedDate.Location = new System.Drawing.Point(6, 49);
            this.trbSelectedDate.Name = "trbSelectedDate";
            this.trbSelectedDate.Size = new System.Drawing.Size(487, 45);
            this.trbSelectedDate.TabIndex = 0;
            // 
            // tbRoomsOccupied
            // 
            this.tbRoomsOccupied.Location = new System.Drawing.Point(113, 145);
            this.tbRoomsOccupied.Name = "tbRoomsOccupied";
            this.tbRoomsOccupied.ReadOnly = true;
            this.tbRoomsOccupied.Size = new System.Drawing.Size(44, 20);
            this.tbRoomsOccupied.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rooms occupied:";
            // 
            // cbHolidayPeriods
            // 
            this.cbHolidayPeriods.FormattingEnabled = true;
            this.cbHolidayPeriods.Location = new System.Drawing.Point(100, 12);
            this.cbHolidayPeriods.Name = "cbHolidayPeriods";
            this.cbHolidayPeriods.Size = new System.Drawing.Size(170, 21);
            this.cbHolidayPeriods.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Holiday period:";
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 489);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHolidayPeriods);
            this.Controls.Add(this.tbRoomsOccupied);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(539, 528);
            this.MinimumSize = new System.Drawing.Size(539, 528);
            this.Name = "LogView";
            this.Text = "LogView";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSelectedDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btIncrementDate;
        private System.Windows.Forms.Button btDecrementDate;
        private System.Windows.Forms.TextBox tbSelectedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TrackBar trbSelectedDate;
        private System.Windows.Forms.TextBox tbRoomsOccupied;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHolidayPeriods;
        private System.Windows.Forms.Label label5;
    }
}