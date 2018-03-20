﻿using System;

using Windows.UI.Xaml.Controls;

namespace MF_UWP_proto.Models
{
    // TODO WTS: Remove this class once your pages/features are using your data.
    // This is used by the SampleDataService.
    // It is the model class we use to display data on pages like Grid, Chart, and Master Detail.
    public class SampleOrder
    {
        public long OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string Company { get; set; }

        public string ShipTo { get; set; }

        public double OrderTotal { get; set; }

        public string Status { get; set; }

        public Symbol Symbol { get; set; }

        public char SymbolAsChar => (char)Symbol;

        public string HashIdentIcon => GetHashCode().ToString() + "-icon";

        public string HashIdentTitle => GetHashCode().ToString() + "-title";

        public override string ToString()
        {
            return $"{Company} {Status}";
        }
    }
}
