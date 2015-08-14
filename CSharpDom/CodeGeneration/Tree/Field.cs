using System;
using System.Linq.Expressions;

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

        public string RawInitialValue { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
