
namespace DigitClassification
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picDigit = new System.Windows.Forms.PictureBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.nClass = new System.Windows.Forms.NumericUpDown();
            this.lblLabel = new System.Windows.Forms.Label();
            this.nScale = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpClassify = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).BeginInit();
            this.grpClassify.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPredict);
            this.panel1.Controls.Add(this.nClass);
            this.panel1.Controls.Add(this.picDigit);
            this.panel1.Controls.Add(this.btnTrain);
            this.panel1.Location = new System.Drawing.Point(23, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 196);
            this.panel1.TabIndex = 6;
            // 
            // picDigit
            // 
            this.picDigit.BackColor = System.Drawing.Color.White;
            this.picDigit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDigit.Location = new System.Drawing.Point(11, 28);
            this.picDigit.Margin = new System.Windows.Forms.Padding(2);
            this.picDigit.Name = "picDigit";
            this.picDigit.Size = new System.Drawing.Size(156, 156);
            this.picDigit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDigit.TabIndex = 0;
            this.picDigit.TabStop = false;
            this.picDigit.Click += new System.EventHandler(this.picDigit_Click);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.DimGray;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreview.Location = new System.Drawing.Point(11, 25);
            this.picPreview.Margin = new System.Windows.Forms.Padding(2);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(156, 151);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.picPreview);
            this.panel2.Controls.Add(this.nScale);
            this.panel2.Controls.Add(this.btnScale);
            this.panel2.Location = new System.Drawing.Point(23, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 187);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(235, 79);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(104, 32);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnScale
            // 
            this.btnScale.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScale.Location = new System.Drawing.Point(235, 125);
            this.btnScale.Margin = new System.Windows.Forms.Padding(2);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(107, 32);
            this.btnScale.TabIndex = 1;
            this.btnScale.Text = "Scale";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.Location = new System.Drawing.Point(235, 129);
            this.btnPredict.Margin = new System.Windows.Forms.Padding(2);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(104, 32);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // nClass
            // 
            this.nClass.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nClass.Location = new System.Drawing.Point(235, 28);
            this.nClass.Margin = new System.Windows.Forms.Padding(2);
            this.nClass.Name = "nClass";
            this.nClass.Size = new System.Drawing.Size(104, 36);
            this.nClass.TabIndex = 5;
            this.nClass.ValueChanged += new System.EventHandler(this.nClass_ValueChanged);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Mongolian Baiti", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(14, 43);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(0, 102);
            this.lblLabel.TabIndex = 4;
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            // 
            // nScale
            // 
            this.nScale.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nScale.Location = new System.Drawing.Point(235, 74);
            this.nScale.Margin = new System.Windows.Forms.Padding(2);
            this.nScale.Name = "nScale";
            this.nScale.Size = new System.Drawing.Size(107, 36);
            this.nScale.TabIndex = 0;
            this.nScale.ValueChanged += new System.EventHandler(this.nScale_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(235, 25);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpClassify
            // 
            this.grpClassify.Controls.Add(this.panel3);
            this.grpClassify.Controls.Add(this.panel2);
            this.grpClassify.Controls.Add(this.panel1);
            this.grpClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpClassify.Location = new System.Drawing.Point(0, 0);
            this.grpClassify.Margin = new System.Windows.Forms.Padding(2);
            this.grpClassify.Name = "grpClassify";
            this.grpClassify.Padding = new System.Windows.Forms.Padding(2);
            this.grpClassify.Size = new System.Drawing.Size(705, 419);
            this.grpClassify.TabIndex = 3;
            this.grpClassify.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblLabel);
            this.panel3.Location = new System.Drawing.Point(476, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 167);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recognized Digit:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Draw Any Digit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, -3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scale";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 419);
            this.Controls.Add(this.grpClassify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handwritten Digit Recognition Tool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).EndInit();
            this.grpClassify.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.PictureBox picDigit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown nScale;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.NumericUpDown nClass;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.GroupBox grpClassify;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

