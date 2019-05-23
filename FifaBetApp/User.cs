using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FifaBetApp
{
    [Serializable()]
    class User : ISerializable
    {
        private string v;

        public string Name { get; set; }
        public int Cash { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Cash", Cash);
        }

        public User(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
        }

        public User(string v)
        {
            this.v = v;
        }
    }
}
