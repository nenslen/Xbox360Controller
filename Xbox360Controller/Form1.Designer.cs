﻿namespace XboxControllerTest {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblLeftStickX = new System.Windows.Forms.Label();
            this.lblLeftStickY = new System.Windows.Forms.Label();
            this.lblRightStickY = new System.Windows.Forms.Label();
            this.lblRightStickX = new System.Windows.Forms.Label();
            this.lblLeftTrigger = new System.Windows.Forms.Label();
            this.lblRightTrigger = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.pbLeftStickX = new System.Windows.Forms.ProgressBar();
            this.pbLeftStickY = new System.Windows.Forms.ProgressBar();
            this.pbRightStickX = new System.Windows.Forms.ProgressBar();
            this.pbRightStickY = new System.Windows.Forms.ProgressBar();
            this.pbLeftTrigger = new System.Windows.Forms.ProgressBar();
            this.pbRightTrigger = new System.Windows.Forms.ProgressBar();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbY = new System.Windows.Forms.CheckBox();
            this.cbX = new System.Windows.Forms.CheckBox();
            this.cbRightStick = new System.Windows.Forms.CheckBox();
            this.cbLeftStick = new System.Windows.Forms.CheckBox();
            this.cbRB = new System.Windows.Forms.CheckBox();
            this.cbLB = new System.Windows.Forms.CheckBox();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.cbBack = new System.Windows.Forms.CheckBox();
            this.tbLeftMotor = new System.Windows.Forms.TrackBar();
            this.tbRightMotor = new System.Windows.Forms.TrackBar();
            this.lblLeftMotor = new System.Windows.Forms.Label();
            this.lblRightMotor = new System.Windows.Forms.Label();
            this.cbDL = new System.Windows.Forms.CheckBox();
            this.cbDD = new System.Windows.Forms.CheckBox();
            this.cbDR = new System.Windows.Forms.CheckBox();
            this.cbDU = new System.Windows.Forms.CheckBox();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblBatteryLevel = new System.Windows.Forms.Label();
            this.lblBatteryType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMotor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 50;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblLeftStickX
            // 
            this.lblLeftStickX.AutoSize = true;
            this.lblLeftStickX.Location = new System.Drawing.Point(10, 112);
            this.lblLeftStickX.Name = "lblLeftStickX";
            this.lblLeftStickX.Size = new System.Drawing.Size(65, 13);
            this.lblLeftStickX.TabIndex = 1;
            this.lblLeftStickX.Text = "Left Stick X:";
            // 
            // lblLeftStickY
            // 
            this.lblLeftStickY.AutoSize = true;
            this.lblLeftStickY.Location = new System.Drawing.Point(10, 151);
            this.lblLeftStickY.Name = "lblLeftStickY";
            this.lblLeftStickY.Size = new System.Drawing.Size(65, 13);
            this.lblLeftStickY.TabIndex = 10;
            this.lblLeftStickY.Text = "Left Stick Y:";
            // 
            // lblRightStickY
            // 
            this.lblRightStickY.AutoSize = true;
            this.lblRightStickY.Location = new System.Drawing.Point(10, 229);
            this.lblRightStickY.Name = "lblRightStickY";
            this.lblRightStickY.Size = new System.Drawing.Size(72, 13);
            this.lblRightStickY.TabIndex = 12;
            this.lblRightStickY.Text = "Right Stick Y:";
            // 
            // lblRightStickX
            // 
            this.lblRightStickX.AutoSize = true;
            this.lblRightStickX.Location = new System.Drawing.Point(10, 190);
            this.lblRightStickX.Name = "lblRightStickX";
            this.lblRightStickX.Size = new System.Drawing.Size(72, 13);
            this.lblRightStickX.TabIndex = 11;
            this.lblRightStickX.Text = "Right Stick X:";
            // 
            // lblLeftTrigger
            // 
            this.lblLeftTrigger.AutoSize = true;
            this.lblLeftTrigger.Location = new System.Drawing.Point(10, 268);
            this.lblLeftTrigger.Name = "lblLeftTrigger";
            this.lblLeftTrigger.Size = new System.Drawing.Size(64, 13);
            this.lblLeftTrigger.TabIndex = 13;
            this.lblLeftTrigger.Text = "Left Trigger:";
            // 
            // lblRightTrigger
            // 
            this.lblRightTrigger.AutoSize = true;
            this.lblRightTrigger.Location = new System.Drawing.Point(10, 307);
            this.lblRightTrigger.Name = "lblRightTrigger";
            this.lblRightTrigger.Size = new System.Drawing.Size(71, 13);
            this.lblRightTrigger.TabIndex = 14;
            this.lblRightTrigger.Text = "Right Trigger:";
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.ForeColor = System.Drawing.Color.Red;
            this.lblConnected.Location = new System.Drawing.Point(56, 9);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(73, 13);
            this.lblConnected.TabIndex = 15;
            this.lblConnected.Text = "Disconnected";
            // 
            // pbLeftStickX
            // 
            this.pbLeftStickX.Location = new System.Drawing.Point(13, 128);
            this.pbLeftStickX.Name = "pbLeftStickX";
            this.pbLeftStickX.Size = new System.Drawing.Size(222, 20);
            this.pbLeftStickX.TabIndex = 16;
            // 
            // pbLeftStickY
            // 
            this.pbLeftStickY.Location = new System.Drawing.Point(13, 167);
            this.pbLeftStickY.Name = "pbLeftStickY";
            this.pbLeftStickY.Size = new System.Drawing.Size(222, 20);
            this.pbLeftStickY.TabIndex = 17;
            // 
            // pbRightStickX
            // 
            this.pbRightStickX.Location = new System.Drawing.Point(13, 206);
            this.pbRightStickX.Name = "pbRightStickX";
            this.pbRightStickX.Size = new System.Drawing.Size(222, 20);
            this.pbRightStickX.TabIndex = 18;
            // 
            // pbRightStickY
            // 
            this.pbRightStickY.Location = new System.Drawing.Point(13, 245);
            this.pbRightStickY.Name = "pbRightStickY";
            this.pbRightStickY.Size = new System.Drawing.Size(222, 20);
            this.pbRightStickY.TabIndex = 19;
            // 
            // pbLeftTrigger
            // 
            this.pbLeftTrigger.Location = new System.Drawing.Point(13, 284);
            this.pbLeftTrigger.Name = "pbLeftTrigger";
            this.pbLeftTrigger.Size = new System.Drawing.Size(222, 20);
            this.pbLeftTrigger.TabIndex = 20;
            // 
            // pbRightTrigger
            // 
            this.pbRightTrigger.Location = new System.Drawing.Point(13, 323);
            this.pbRightTrigger.Name = "pbRightTrigger";
            this.pbRightTrigger.Size = new System.Drawing.Size(222, 20);
            this.pbRightTrigger.TabIndex = 21;
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Location = new System.Drawing.Point(265, 75);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(33, 17);
            this.cbA.TabIndex = 22;
            this.cbA.Text = "A";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(265, 98);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(33, 17);
            this.cbB.TabIndex = 23;
            this.cbB.Text = "B";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbY
            // 
            this.cbY.AutoSize = true;
            this.cbY.Location = new System.Drawing.Point(265, 144);
            this.cbY.Name = "cbY";
            this.cbY.Size = new System.Drawing.Size(33, 17);
            this.cbY.TabIndex = 25;
            this.cbY.Text = "Y";
            this.cbY.UseVisualStyleBackColor = true;
            // 
            // cbX
            // 
            this.cbX.AutoSize = true;
            this.cbX.Location = new System.Drawing.Point(265, 121);
            this.cbX.Name = "cbX";
            this.cbX.Size = new System.Drawing.Size(33, 17);
            this.cbX.TabIndex = 24;
            this.cbX.Text = "X";
            this.cbX.UseVisualStyleBackColor = true;
            // 
            // cbRightStick
            // 
            this.cbRightStick.AutoSize = true;
            this.cbRightStick.Location = new System.Drawing.Point(265, 236);
            this.cbRightStick.Name = "cbRightStick";
            this.cbRightStick.Size = new System.Drawing.Size(78, 17);
            this.cbRightStick.TabIndex = 29;
            this.cbRightStick.Text = "Right Stick";
            this.cbRightStick.UseVisualStyleBackColor = true;
            // 
            // cbLeftStick
            // 
            this.cbLeftStick.AutoSize = true;
            this.cbLeftStick.Location = new System.Drawing.Point(265, 213);
            this.cbLeftStick.Name = "cbLeftStick";
            this.cbLeftStick.Size = new System.Drawing.Size(71, 17);
            this.cbLeftStick.TabIndex = 28;
            this.cbLeftStick.Text = "Left Stick";
            this.cbLeftStick.UseVisualStyleBackColor = true;
            // 
            // cbRB
            // 
            this.cbRB.AutoSize = true;
            this.cbRB.Location = new System.Drawing.Point(265, 190);
            this.cbRB.Name = "cbRB";
            this.cbRB.Size = new System.Drawing.Size(41, 17);
            this.cbRB.TabIndex = 27;
            this.cbRB.Text = "RB";
            this.cbRB.UseVisualStyleBackColor = true;
            // 
            // cbLB
            // 
            this.cbLB.AutoSize = true;
            this.cbLB.Location = new System.Drawing.Point(265, 167);
            this.cbLB.Name = "cbLB";
            this.cbLB.Size = new System.Drawing.Size(39, 17);
            this.cbLB.TabIndex = 26;
            this.cbLB.Text = "LB";
            this.cbLB.UseVisualStyleBackColor = true;
            // 
            // cbStart
            // 
            this.cbStart.AutoSize = true;
            this.cbStart.Location = new System.Drawing.Point(265, 282);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(48, 17);
            this.cbStart.TabIndex = 31;
            this.cbStart.Text = "Start";
            this.cbStart.UseVisualStyleBackColor = true;
            // 
            // cbBack
            // 
            this.cbBack.AutoSize = true;
            this.cbBack.Location = new System.Drawing.Point(265, 259);
            this.cbBack.Name = "cbBack";
            this.cbBack.Size = new System.Drawing.Size(51, 17);
            this.cbBack.TabIndex = 30;
            this.cbBack.Text = "Back";
            this.cbBack.UseVisualStyleBackColor = true;
            // 
            // tbLeftMotor
            // 
            this.tbLeftMotor.Location = new System.Drawing.Point(13, 390);
            this.tbLeftMotor.Maximum = 100;
            this.tbLeftMotor.Name = "tbLeftMotor";
            this.tbLeftMotor.Size = new System.Drawing.Size(93, 45);
            this.tbLeftMotor.TabIndex = 33;
            this.tbLeftMotor.TickFrequency = 10;
            // 
            // tbRightMotor
            // 
            this.tbRightMotor.Location = new System.Drawing.Point(112, 390);
            this.tbRightMotor.Maximum = 100;
            this.tbRightMotor.Name = "tbRightMotor";
            this.tbRightMotor.Size = new System.Drawing.Size(93, 45);
            this.tbRightMotor.TabIndex = 34;
            this.tbRightMotor.TickFrequency = 10;
            // 
            // lblLeftMotor
            // 
            this.lblLeftMotor.AutoSize = true;
            this.lblLeftMotor.Location = new System.Drawing.Point(10, 374);
            this.lblLeftMotor.Name = "lblLeftMotor";
            this.lblLeftMotor.Size = new System.Drawing.Size(55, 13);
            this.lblLeftMotor.TabIndex = 35;
            this.lblLeftMotor.Text = "Left Motor";
            // 
            // lblRightMotor
            // 
            this.lblRightMotor.AutoSize = true;
            this.lblRightMotor.Location = new System.Drawing.Point(109, 374);
            this.lblRightMotor.Name = "lblRightMotor";
            this.lblRightMotor.Size = new System.Drawing.Size(62, 13);
            this.lblRightMotor.TabIndex = 36;
            this.lblRightMotor.Text = "Right Motor";
            // 
            // cbDL
            // 
            this.cbDL.AutoSize = true;
            this.cbDL.Location = new System.Drawing.Point(265, 305);
            this.cbDL.Name = "cbDL";
            this.cbDL.Size = new System.Drawing.Size(55, 17);
            this.cbDL.TabIndex = 37;
            this.cbDL.Text = "D Left";
            this.cbDL.UseVisualStyleBackColor = true;
            // 
            // cbDD
            // 
            this.cbDD.AutoSize = true;
            this.cbDD.Location = new System.Drawing.Point(265, 374);
            this.cbDD.Name = "cbDD";
            this.cbDD.Size = new System.Drawing.Size(65, 17);
            this.cbDD.TabIndex = 38;
            this.cbDD.Text = "D Down";
            this.cbDD.UseVisualStyleBackColor = true;
            // 
            // cbDR
            // 
            this.cbDR.AutoSize = true;
            this.cbDR.Location = new System.Drawing.Point(265, 351);
            this.cbDR.Name = "cbDR";
            this.cbDR.Size = new System.Drawing.Size(62, 17);
            this.cbDR.TabIndex = 39;
            this.cbDR.Text = "D Right";
            this.cbDR.UseVisualStyleBackColor = true;
            // 
            // cbDU
            // 
            this.cbDU.AutoSize = true;
            this.cbDU.Location = new System.Drawing.Point(265, 328);
            this.cbDU.Name = "cbDU";
            this.cbDU.Size = new System.Drawing.Size(51, 17);
            this.cbDU.TabIndex = 40;
            this.cbDU.Text = "D Up";
            this.cbDU.UseVisualStyleBackColor = true;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(10, 35);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(72, 13);
            this.lblBattery.TabIndex = 41;
            this.lblBattery.Text = "Battery Level:";
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.BackColor = System.Drawing.SystemColors.Control;
            this.lblBatteryLevel.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBatteryLevel.Location = new System.Drawing.Point(88, 35);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(36, 13);
            this.lblBatteryLevel.TabIndex = 42;
            this.lblBatteryLevel.Text = "Empty";
            // 
            // lblBatteryType
            // 
            this.lblBatteryType.AutoSize = true;
            this.lblBatteryType.Location = new System.Drawing.Point(10, 61);
            this.lblBatteryType.Name = "lblBatteryType";
            this.lblBatteryType.Size = new System.Drawing.Size(70, 13);
            this.lblBatteryType.TabIndex = 43;
            this.lblBatteryType.Text = "Battery Type:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 451);
            this.Controls.Add(this.lblBatteryType);
            this.Controls.Add(this.lblBatteryLevel);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.cbDU);
            this.Controls.Add(this.cbDR);
            this.Controls.Add(this.cbDD);
            this.Controls.Add(this.cbDL);
            this.Controls.Add(this.lblRightMotor);
            this.Controls.Add(this.lblLeftMotor);
            this.Controls.Add(this.tbRightMotor);
            this.Controls.Add(this.tbLeftMotor);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.cbBack);
            this.Controls.Add(this.cbRightStick);
            this.Controls.Add(this.cbLeftStick);
            this.Controls.Add(this.cbRB);
            this.Controls.Add(this.cbLB);
            this.Controls.Add(this.cbY);
            this.Controls.Add(this.cbX);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.pbRightTrigger);
            this.Controls.Add(this.pbLeftTrigger);
            this.Controls.Add(this.pbRightStickY);
            this.Controls.Add(this.pbRightStickX);
            this.Controls.Add(this.pbLeftStickY);
            this.Controls.Add(this.pbLeftStickX);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.lblRightTrigger);
            this.Controls.Add(this.lblLeftTrigger);
            this.Controls.Add(this.lblRightStickY);
            this.Controls.Add(this.lblRightStickX);
            this.Controls.Add(this.lblLeftStickY);
            this.Controls.Add(this.lblLeftStickX);
            this.Controls.Add(this.lblStatus);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMotor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMotor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblLeftStickX;
        private System.Windows.Forms.Label lblLeftStickY;
        private System.Windows.Forms.Label lblRightStickY;
        private System.Windows.Forms.Label lblRightStickX;
        private System.Windows.Forms.Label lblLeftTrigger;
        private System.Windows.Forms.Label lblRightTrigger;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.ProgressBar pbLeftStickX;
        private System.Windows.Forms.ProgressBar pbLeftStickY;
        private System.Windows.Forms.ProgressBar pbRightStickX;
        private System.Windows.Forms.ProgressBar pbRightStickY;
        private System.Windows.Forms.ProgressBar pbLeftTrigger;
        private System.Windows.Forms.ProgressBar pbRightTrigger;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbY;
        private System.Windows.Forms.CheckBox cbX;
        private System.Windows.Forms.CheckBox cbRightStick;
        private System.Windows.Forms.CheckBox cbLeftStick;
        private System.Windows.Forms.CheckBox cbRB;
        private System.Windows.Forms.CheckBox cbLB;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.CheckBox cbBack;
        private System.Windows.Forms.TrackBar tbLeftMotor;
        private System.Windows.Forms.TrackBar tbRightMotor;
        private System.Windows.Forms.Label lblLeftMotor;
        private System.Windows.Forms.Label lblRightMotor;
        private System.Windows.Forms.CheckBox cbDL;
        private System.Windows.Forms.CheckBox cbDD;
        private System.Windows.Forms.CheckBox cbDR;
        private System.Windows.Forms.CheckBox cbDU;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblBatteryLevel;
        private System.Windows.Forms.Label lblBatteryType;
    }
}

