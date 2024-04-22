
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
            this.grpPicture = new System.Windows.Forms.GroupBox();
            this.picDigit = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.nScale = new System.Windows.Forms.NumericUpDown();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.grpClassify = new System.Windows.Forms.GroupBox();
            this.nClass = new System.Windows.Forms.NumericUpDown();
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.grpPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDigit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).BeginInit();
            this.grpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.grpClassify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClass)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPicture
            // 
            this.grpPicture.Controls.Add(this.picDigit);
            this.grpPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPicture.Location = new System.Drawing.Point(0, 0);
            this.grpPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPicture.Name = "grpPicture";
            this.grpPicture.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPicture.Size = new System.Drawing.Size(188, 195);
            this.grpPicture.TabIndex = 0;
            this.grpPicture.TabStop = false;
            this.grpPicture.Text = "Draw Digit";
            // 
            // picDigit
            // 
            this.picDigit.BackColor = System.Drawing.Color.White;
            this.picDigit.Location = new System.Drawing.Point(8, 16);
            this.picDigit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDigit.Name = "picDigit";
            this.picDigit.Size = new System.Drawing.Size(171, 166);
            this.picDigit.TabIndex = 0;
            this.picDigit.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnScale);
            this.groupBox1.Controls.Add(this.nScale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(188, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(91, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scale";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 24);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 21);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnScale
            // 
            this.btnScale.Location = new System.Drawing.Point(5, 93);
            this.btnScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(80, 21);
            this.btnScale.TabIndex = 1;
            this.btnScale.Text = "Scale";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // nScale
            // 
            this.nScale.Location = new System.Drawing.Point(5, 72);
            this.nScale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nScale.Name = "nScale";
            this.nScale.Size = new System.Drawing.Size(80, 20);
            this.nScale.TabIndex = 0;
            this.nScale.ValueChanged += new System.EventHandler(this.nScale_ValueChanged);
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.picPreview);
            this.grpPreview.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPreview.Location = new System.Drawing.Point(279, 0);
            this.grpPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPreview.Size = new System.Drawing.Size(188, 195);
            this.grpPreview.TabIndex = 2;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.DimGray;
            this.picPreview.Location = new System.Drawing.Point(8, 16);
            this.picPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(171, 166);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // grpClassify
            // 
            this.grpClassify.Controls.Add(this.nClass);
            this.grpClassify.Controls.Add(this.lblLabel);
            this.grpClassify.Controls.Add(this.btnPredict);
            this.grpClassify.Controls.Add(this.btnTrain);
            this.grpClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpClassify.Location = new System.Drawing.Point(467, 0);
            this.grpClassify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpClassify.Name = "grpClassify";
            this.grpClassify.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpClassify.Size = new System.Drawing.Size(90, 195);
            this.grpClassify.TabIndex = 3;
            this.grpClassify.TabStop = false;
            this.grpClassify.Text = "Classifier";
            // 
            // nClass
            // 
            this.nClass.Location = new System.Drawing.Point(6, 27);
            this.nClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nClass.Name = "nClass";
            this.nClass.Size = new System.Drawing.Size(80, 20);
            this.nClass.TabIndex = 5;
            this.nClass.ValueChanged += new System.EventHandler(this.nClass_ValueChanged);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(1, 101);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(36, 13);
            this.lblLabel.TabIndex = 4;
            this.lblLabel.Text = "Label:";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(4, 72);
            this.btnPredict.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(82, 21);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(4, 47);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(82, 21);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 195);
            this.Controls.Add(this.grpClassify);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handwritten Digit Recognition Tool";
            this.grpPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDigit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).EndInit();
            this.grpPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.grpClassify.ResumeLayout(false);
            this.grpClassify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPicture;
        private System.Windows.Forms.PictureBox picDigit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nScale;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.GroupBox grpClassify;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.NumericUpDown nClass;
        private System.Windows.Forms.Button btnClear;
    }
}

