using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MysteryBox
    {
        private string _label;
        private string _contains;
        private bool _isExplosive;

        public MysteryBox(string Label, string Contains, bool IsExplosive) 
        { 
            _label = Label;
            _contains = Contains;
            _isExplosive = IsExplosive;
        }


        public string Label
        {
            get { return Label; }
            set { Label = value; }
        }

        public string Contains
        {
            get { return Contains; }
            set { Contains = value; }
        }

        public bool IsExplosive
        {
            get { return IsExplosive; }
            set { IsExplosive = value; }
        }




    }
}
