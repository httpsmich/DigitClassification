﻿using System;

namespace DigitClassification
{
    public class DataPoint
    {
        public double[] Point { get; private set; }
        public string Label { get; private set; }
        private DataPoint(double[] point, string label)
        {
            Point = point;
            Label = label;
        }

        public static DataPoint Create(double[] point, string label)
        {
            if (point == null || label == null) throw new ArgumentException("Arguments can not be null");

            return new DataPoint(point, label);
        }
    }
}
