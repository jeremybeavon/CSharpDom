using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassConstructor
    {
        public ClassConstructor()
        {
            Attributes = new Collection<AttributeGroup>();
            Parameters = new Collection<MethodParameter>();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public Collection<Statement> Statements { get; set; }
    }
}
