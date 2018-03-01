using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassAutoProperty
    {
        private EmptyClassPropertyAccessors emptyAccessors;
        
        public ClassAutoProperty(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            emptyAccessors = new EmptyClassPropertyAccessors();
            Visibility = ClassMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference Type { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors { get; set; }

        public Expression<Func<object>> InitialValue { get; set; }

        public override string ToString()
        {
            return new ReadOnlyClassAutoProperty(this).ToSourceCode();
        }
    }
}
