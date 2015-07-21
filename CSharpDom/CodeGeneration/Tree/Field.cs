using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Field : CodeGenerationNode
    {
        public Field(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public Expression<Func<object>> InitialValue { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
