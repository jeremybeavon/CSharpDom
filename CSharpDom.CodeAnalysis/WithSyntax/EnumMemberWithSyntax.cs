using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class EnumMemberWithSyntax : AbstractSyntaxNode<IEnumMemberSyntax>
    {
        private readonly IEnumMemberSyntax enumMember;

        public EnumMemberWithSyntax(IEnumMemberSyntax enumMember)
            : base(enumMember)
        {
            this.enumMember = enumMember;
        }

        public EnumMemberDeclarationSyntax Declaration
        {
            get { return enumMember.Declaration; }
        }

        public EnumWithSyntax DeclaringType
        {
            get { return new EnumWithSyntax(enumMember.DeclaringType); }
        }

        public int EndLine
        {
            get { return enumMember.EndLine; }
        }

        public string Name
        {
            get { return enumMember.Name; }
        }

        public int StartLine
        {
            get { return enumMember.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            enumMember.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitEnumMember(this);
        }
    }
}
