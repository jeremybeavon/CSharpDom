using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructAutoProperty
    {
        private EmptyStructPropertyAccessors emptyAccessors;
        
        public StructAutoProperty(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            emptyAccessors = new EmptyStructPropertyAccessors();
            Visibility = StructMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public StructMemberInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference Type { get; set; }

        public EmptyStructPropertyAccessors EmptyAccessors { get; set; }

        public Expression<Func<object>> InitialValue { get; set; }

        public override string ToString()
        {
            return new ReadOnlyStructAutoProperty(this).ToSourceCode();
        }
    }
}
