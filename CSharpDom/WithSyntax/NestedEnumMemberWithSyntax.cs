using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class NestedEnumMemberWithSyntax : AbstractSyntaxNode<INestedEnumMemberSyntax>
    {
        private readonly INestedEnumMemberSyntax enumMember;

        public NestedEnumMemberWithSyntax(INestedEnumMemberSyntax enumMember)
            : base(enumMember)
        {
            this.enumMember = enumMember;
        }

        public EnumMemberDeclarationSyntax Declaration
        {
            get { return enumMember.Declaration; }
        }

        public NestedEnumWithSyntax DeclaringType
        {
            get { return new NestedEnumWithSyntax(enumMember.DeclaringType); }
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

        public INestedEnumMemberSyntax AsInterface()
        {
            return enumMember;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            enumMember.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedEnumMember(this);
        }
    }
}
