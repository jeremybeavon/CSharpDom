using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Attribute
    {
        public Attribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public Dictionary<string, object> NamedAttributeValues { get; set; }

        public Collection<object> UnnamedAttributeValues { get; set; }
    }
}
