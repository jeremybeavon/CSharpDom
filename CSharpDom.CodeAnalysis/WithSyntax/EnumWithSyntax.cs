using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class EnumWithSyntax : AbstractSyntaxNode<IEnumSyntax>
    {
        private readonly IEnumSyntax @enum;

        public EnumWithSyntax(IEnumSyntax @enum)
            : base(@enum)
        {
            this.@enum = @enum;
        }

        public EnumDeclarationSyntax Declaration
        {
            get { return @enum.Declaration; }
        }

        public int EndLine
        {
            get { return @enum.EndLine; }
        }

        public IReadOnlyCollection<EnumMemberWithSyntax> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumMemberWithSyntax, IEnumMemberSyntax>(
                    @enum.EnumMembers,
                    enumMember => new EnumMemberWithSyntax(enumMember));
            }
        }

        public string Name
        {
            get { return @enum.Name; }
        }

        public NamespaceWithSyntax Namespace
        {
            get { return new NamespaceWithSyntax(@enum.Namespace); }
        }

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@enum.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@enum.Solution); }
        }

        public int StartLine
        {
            get { return @enum.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @enum.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitEnum(this);
        }
    }
}
