using System;
using System.Xml.Serialization;

namespace Theory
{
    [Serializable]
    internal class Person
    {

        [NonSerialized]
        [XmlIgnore]
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
       
        public string Name { get; set; }
        public DateTime Datebirth { get; set; }
    }
}