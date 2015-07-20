using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Field
    {
        public Field(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string RawInitialValue { get; set; }
    }
}
