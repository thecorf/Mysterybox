using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            get { return _label; }
            set { Label = value; }
        }

        public string Contains
        {
            get { return _contains; }
            set { Contains = value; }
        }

        public bool IsExplosive
        {
            get { return _isExplosive; }
            set { IsExplosive = value; }
        }

        public override string ToString()
        {
            return $"\nLabel: {Label} \n Contains: {Contains} \n Is it Explosive?: {IsExplosive}";
        }


    }
}
