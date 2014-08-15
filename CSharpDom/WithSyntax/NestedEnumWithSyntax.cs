using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class NestedEnumWithSyntax : AbstractSyntaxNode<INestedEnumSyntax>
    {
        private readonly INestedEnumSyntax @enum;

        public NestedEnumWithSyntax(INestedEnumSyntax @enum)
            : base(@enum)
        {
            this.@enum = @enum;
        }

        public EnumDeclarationSyntax Declaration
        {
            get { return @enum.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(@enum.DeclaringType); }
        }

        public int EndLine
        {
            get { return @enum.EndLine; }
        }

        public IReadOnlyCollection<NestedEnumMemberWithSyntax> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumMemberWithSyntax, INestedEnumMemberSyntax>(
                    @enum.EnumMembers,
                    enumMember => new NestedEnumMemberWithSyntax(enumMember));
            }
        }

        public string Name
        {
            get { return @enum.Name; }
        }

        public int StartLine
        {
            get { return @enum.StartLine; }
        }

        public INestedEnumSyntax AsInterface()
        {
            return @enum;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @enum.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedEnum(this);
        }
    }
}
