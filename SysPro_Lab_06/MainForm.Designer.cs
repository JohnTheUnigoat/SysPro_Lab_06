﻿namespace SysPro_Lab_06
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.tbHolidaySeasonEnd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.trbDaycycleSpeed = new System.Windows.Forms.TrackBar();
            this.gbSpeedControl = new System.Windows.Forms.GroupBox();
            this.gbSeasonControl = new System.Windows.Forms.GroupBox();
            this.btStart = new System.Windows.Forms.Button();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHotelStatus = new System.Windows.Forms.TextBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.tbRoomsOccupied = new System.Windows.Forms.TextBox();
            this.btLoadFromFile = new System.Windows.Forms.Button();
            this.btViewLogs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDaycycleSpeed)).BeginInit();
            this.gbSpeedControl.SuspendLayout();
            this.gbSeasonControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Holiday season ends:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of occupied rooms:";
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Location = new System.Drawing.Point(203, 14);
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.ReadOnly = true;
            this.tbCurrentDate.Size = new System.Drawing.Size(157, 22);
            this.tbCurrentDate.TabIndex = 3;
            // 
            // tbHolidaySeasonEnd
            // 
            this.tbHolidaySeasonEnd.Location = new System.Drawing.Point(203, 42);
            this.tbHolidaySeasonEnd.Name = "tbHolidaySeasonEnd";
            this.tbHolidaySeasonEnd.ReadOnly = true;
            this.tbHolidaySeasonEnd.Size = new System.Drawing.Size(157, 22);
            this.tbHolidaySeasonEnd.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvRooms);
            this.groupBox1.Location = new System.Drawing.Point(18, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 306);
            this.groupBox1.TabIndex = 6;
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
            this.dgvRooms.Size = new System.Drawing.Size(487, 279);
            this.dgvRooms.TabIndex = 0;
            // 
            // trbDaycycleSpeed
            // 
            this.trbDaycycleSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbDaycycleSpeed.Location = new System.Drawing.Point(6, 21);
            this.trbDaycycleSpeed.Maximum = 15;
            this.trbDaycycleSpeed.Name = "trbDaycycleSpeed";
            this.trbDaycycleSpeed.Size = new System.Drawing.Size(158, 45);
            this.trbDaycycleSpeed.TabIndex = 8;
            this.trbDaycycleSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbDaycycleSpeed.Value = 5;
            // 
            // gbSpeedControl
            // 
            this.gbSpeedControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSpeedControl.Controls.Add(this.trbDaycycleSpeed);
            this.gbSpeedControl.Location = new System.Drawing.Point(18, 415);
            this.gbSpeedControl.Name = "gbSpeedControl";
            this.gbSpeedControl.Size = new System.Drawing.Size(170, 75);
            this.gbSpeedControl.TabIndex = 9;
            this.gbSpeedControl.TabStop = false;
            this.gbSpeedControl.Text = "Daycycle speed";
            // 
            // gbSeasonControl
            // 
            this.gbSeasonControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSeasonControl.Controls.Add(this.btStart);
            this.gbSeasonControl.Controls.Add(this.numDuration);
            this.gbSeasonControl.Controls.Add(this.label4);
            this.gbSeasonControl.Location = new System.Drawing.Point(194, 415);
            this.gbSeasonControl.Name = "gbSeasonControl";
            this.gbSeasonControl.Size = new System.Drawing.Size(323, 75);
            this.gbSeasonControl.TabIndex = 10;
            this.gbSeasonControl.TabStop = false;
            this.gbSeasonControl.Text = "Holiday season";
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(208, 13);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(109, 56);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(14, 44);
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(124, 22);
            this.numDuration.TabIndex = 1;
            this.numDuration.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duration (days):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "The hotel is";
            // 
            // tbHotelStatus
            // 
            this.tbHotelStatus.Location = new System.Drawing.Point(410, 54);
            this.tbHotelStatus.Name = "tbHotelStatus";
            this.tbHotelStatus.ReadOnly = true;
            this.tbHotelStatus.Size = new System.Drawing.Size(74, 22);
            this.tbHotelStatus.TabIndex = 12;
            this.tbHotelStatus.Text = "Closed";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            // 
            // tbRoomsOccupied
            // 
            this.tbRoomsOccupied.Location = new System.Drawing.Point(203, 70);
            this.tbRoomsOccupied.Name = "tbRoomsOccupied";
            this.tbRoomsOccupied.ReadOnly = true;
            this.tbRoomsOccupied.Size = new System.Drawing.Size(157, 22);
            this.tbRoomsOccupied.TabIndex = 13;
            // 
            // btLoadFromFile
            // 
            this.btLoadFromFile.Location = new System.Drawing.Point(18, 498);
            this.btLoadFromFile.Name = "btLoadFromFile";
            this.btLoadFromFile.Size = new System.Drawing.Size(247, 34);
            this.btLoadFromFile.TabIndex = 14;
            this.btLoadFromFile.Text = "Load from file";
            this.btLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // btViewLogs
            // 
            this.btViewLogs.Location = new System.Drawing.Point(270, 498);
            this.btViewLogs.Name = "btViewLogs";
            this.btViewLogs.Size = new System.Drawing.Size(247, 34);
            this.btViewLogs.TabIndex = 15;
            this.btViewLogs.Text = "View logs";
            this.btViewLogs.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 544);
            this.Controls.Add(this.btViewLogs);
            this.Controls.Add(this.btLoadFromFile);
            this.Controls.Add(this.tbRoomsOccupied);
            this.Controls.Add(this.tbHotelStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbSeasonControl);
            this.Controls.Add(this.gbSpeedControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbHolidaySeasonEnd);
            this.Controls.Add(this.tbCurrentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 583);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 583);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDaycycleSpeed)).EndInit();
            this.gbSpeedControl.ResumeLayout(false);
            this.gbSpeedControl.PerformLayout();
            this.gbSeasonControl.ResumeLayout(false);
            this.gbSeasonControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCurrentDate;
        private System.Windows.Forms.TextBox tbHolidaySeasonEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.TrackBar trbDaycycleSpeed;
        private System.Windows.Forms.GroupBox gbSpeedControl;
        private System.Windows.Forms.GroupBox gbSeasonControl;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHotelStatus;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.TextBox tbRoomsOccupied;
        private System.Windows.Forms.Button btLoadFromFile;
        private System.Windows.Forms.Button btViewLogs;
    }
}

