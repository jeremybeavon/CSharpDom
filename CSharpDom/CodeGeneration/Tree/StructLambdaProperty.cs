using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructLambdaProperty
    {
        public StructLambdaProperty(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Visibility = StructMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public StructMemberInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference Type { get; set; }

        public Expression<Func<object>> LambdaExpression { get; set; }

        public override string ToString()
        {
            return new ReadOnlyStructLambdaProperty(this).ToSourceCode();
        }
    }
}
