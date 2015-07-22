using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyStructPropertyAccessors : CodeGenerationNode
    {
        public EmptyStructPropertyAccessors()
        {
        }

        public EmptyStructPropertyAccessors(
            StructPropertyAccessorVisibilityModifier getAccessorVisibility,
            StructPropertyAccessorVisibilityModifier setAccessorVisibility)
        {
            getAccessorVisibility = GetAccessorVisibility;
            SetAccessorVisibility = setAccessorVisibility;
        }

        public StructPropertyAccessorVisibilityModifier GetAccessorVisibility { get; set; }

        public StructPropertyAccessorVisibilityModifier SetAccessorVisibility { get; set; }

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
