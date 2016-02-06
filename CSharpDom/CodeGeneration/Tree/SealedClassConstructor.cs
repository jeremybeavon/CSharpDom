using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SealedClassConstructor
    {
        public SealedClassConstructor()
        {
            Parameters = new Collection<MethodParameter>();
        }

        public SealedClassMemberVisibilityModifier Visibility { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public Collection<Statement> Statements { get; set; }
    }
}
