using Accord.Math;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitClassification
{
    public partial class Form1 : Form
    {
        private DrawController _drawController;
        private DataSet _dataSet = new DataSet();

        public new int Scale { get; set; } = 50;
        private BinaryMatrix _currentBinaryMatrix = BinaryMatrix.Empty();
        private const int BINARYZE_THRESHOLD = 100;
        public Form1()
        {
            InitializeComponent();
            _drawController = new DrawController(picDigit);

            nClass.Maximum = 100000;
            nScale.Maximum = 100000;

            nScale.DataBindings.Add(new Binding("Value", this, "Scale"));
        }

        private void btnClear_Click(object sender, EventArgs e) => _drawController.Clear();

        private void btnScale_Click(object sender, EventArgs e)
        {
            _currentBinaryMatrix = BinaryMatrix.Create(new ImageProcessing(_drawController.Drawing)
                .Grayscale()
                .Binarize(BINARYZE_THRESHOLD)
                .Invert()
                .CropBlob()
                .Resize(Scale, Scale)
                .Binarize(BINARYZE_THRESHOLD)
                .Do((pic) => picPreview.Image = pic)
                .Image,
                0.5f);
            System.IO.File.WriteAllText(@"C:\Users\cabri\Documents\PF101\file.txt", _currentBinaryMatrix.ToString());
        }

        private void btnTrain_Click(object sender, EventArgs e) =>
            _currentBinaryMatrix.Flatten(vector => _dataSet.Add(DataPoint.Create(vector, nClass.Value.ToString())));

        private void btnPredict_Click(object sender, EventArgs e) =>
           _currentBinaryMatrix.Flatten(vector => lblLabel.Text = $"{_dataSet.Predict(vector, Distance.Euclidean)}");


        private void nClass_ValueChanged(object sender, EventArgs e)
        {
            if (nClass.Value > 10000)
            {
                nClass.Value = 10000;
            }
        }

        private void nScale_ValueChanged(object sender, EventArgs e)
        {
            if (nScale.Value > 10000)
            {
                nScale.Value = 10000;
            }
        }

        private void picDigit_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picPreview_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
