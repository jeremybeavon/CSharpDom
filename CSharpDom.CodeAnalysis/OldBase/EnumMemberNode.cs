using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class EnumMemberNode : AbstractNode<EnumMemberDeclarationSyntax, EnumNode>
    {
        protected EnumMemberNode(EnumMemberDeclarationSyntax declaration, EnumNode container)
            : base(declaration, container)
        {
        }

        public EnumNode DeclaringType
        {
            get { return Container; }
        }

        public bool IsNested
        {
            get { return DeclaringType.IsNestedType; }
        }

        public string Name
        {
            get { return Declaration.Identifier.Text; }
        }

        public override string ToString()
        {
            return Declaration.ToString();
        }
    }
}
