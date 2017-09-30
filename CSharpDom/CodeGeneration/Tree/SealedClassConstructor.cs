using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SealedClassConstructor
    {
        public SealedClassConstructor()
        {
            Attributes = new Collection<AttributeGroup>();
            Parameters = new Collection<MethodParameter>();
            Visibility = ClassMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public Collection<Statement> Statements { get; set; }
    }
}
