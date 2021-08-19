using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Listbox___Sample_Application
{
    public class Ruler
    {
        public string Name { get; set; }
        public string reignName { get; set; }
        public string House { get; set; }
        public DateTime Birth { get; set; }

        // Death DateTime can be nullable.
        public DateTime? Death { get; set; }
        public string Predecessor { get; set; }
        public string Successor { get; set; }
        public string Image_URL { get; set; }

        // WPF ListBox uses the ToString() method of the class to decide what to display.
        public override string ToString()
        {
            return reignName;
        }
    }
}
