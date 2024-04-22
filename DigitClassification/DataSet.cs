using System;
using System.Collections.Generic;

namespace DigitClassification
{
    internal class DataSet
    {
        private List<DataPoint> _dataSet = new List<DataPoint>();
        internal void Add(DataPoint dataPoint)
        {
            _dataSet.Add(dataPoint);
        }

        internal string Predict(double[] vector, Func<double[],double[],double> distanceFunction)
        {
            double smallestDistance = Double.MaxValue;
            int min = int.MaxValue;
            for(int i=0;i<_dataSet.Count;i++)
            {
                var distance = distanceFunction(_dataSet[i].Point, vector);
                if (distance< smallestDistance)
                {
                    smallestDistance = distance;
                    min = i;
                }
            }
            return _dataSet[min].Label;
        }
    }
}