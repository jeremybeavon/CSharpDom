using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassConstructor
    {
        public ClassConstructor()
        {
            Parameters = new Collection<MethodParameter>();
        }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public Collection<Statement> Statements { get; set; }
    }
}
