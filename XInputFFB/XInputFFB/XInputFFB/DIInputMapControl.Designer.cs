﻿
namespace XInputFFB
{
    partial class DIInputMapControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblXInput = new System.Windows.Forms.Label();
            this.lblDIInput = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.invertCheckBox = new System.Windows.Forms.CheckBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnForget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXInput
            // 
            this.lblXInput.AutoSize = true;
            this.lblXInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblXInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXInput.Location = new System.Drawing.Point(12, 12);
            this.lblXInput.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblXInput.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblXInput.Name = "lblXInput";
            this.lblXInput.Size = new System.Drawing.Size(140, 19);
            this.lblXInput.TabIndex = 0;
            this.lblXInput.Text = "A Button";
            // 
            // lblDIInput
            // 
            this.lblDIInput.AutoSize = true;
            this.lblDIInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDIInput.Location = new System.Drawing.Point(161, 12);
            this.lblDIInput.MaximumSize = new System.Drawing.Size(470, 0);
            this.lblDIInput.MinimumSize = new System.Drawing.Size(470, 0);
            this.lblDIInput.Name = "lblDIInput";
            this.lblDIInput.Size = new System.Drawing.Size(470, 19);
            this.lblDIInput.TabIndex = 1;
            this.lblDIInput.Text = "Some direct input device and button";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(814, 12);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(108, 23);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "RECORD";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // invertCheckBox
            // 
            this.invertCheckBox.AutoSize = true;
            this.invertCheckBox.Location = new System.Drawing.Point(637, 44);
            this.invertCheckBox.Name = "invertCheckBox";
            this.invertCheckBox.Size = new System.Drawing.Size(65, 21);
            this.invertCheckBox.TabIndex = 3;
            this.invertCheckBox.Text = "Invert";
            this.invertCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue.Location = new System.Drawing.Point(637, 12);
            this.lblValue.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblValue.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(150, 19);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value";
            // 
            // btnForget
            // 
            this.btnForget.Location = new System.Drawing.Point(814, 42);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(108, 23);
            this.btnForget.TabIndex = 5;
            this.btnForget.Text = "FORGET";
            this.btnForget.UseVisualStyleBackColor = true;
            // 
            // DIInputMapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.invertCheckBox);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lblDIInput);
            this.Controls.Add(this.lblXInput);
            this.Name = "DIInputMapControl";
            this.Size = new System.Drawing.Size(930, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXInput;
        private System.Windows.Forms.Label lblDIInput;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.CheckBox invertCheckBox;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnForget;
    }
}
