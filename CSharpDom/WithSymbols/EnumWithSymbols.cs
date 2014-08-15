using System.Collections.Generic;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class EnumWithSymbols : AbstractSymbolNode<IEnumWithSymbols>
    {
        private readonly IEnumWithSymbols @enum;

        public EnumWithSymbols(IEnumWithSymbols @enum)
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

        public IReadOnlyCollection<EnumMemberWithSymbols> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<EnumMemberWithSymbols, IEnumMemberWithSymbols>(
                    @enum.EnumMembers,
                    enumMember => new EnumMemberWithSymbols(enumMember));
            }
        }

        public string Name
        {
            get { return @enum.Name; }
        }

        public NamespaceWithSymbols Namespace
        {
            get { return new NamespaceWithSymbols(@enum.Namespace); }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@enum.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@enum.Solution); }
        }

        public int StartLine
        {
            get { return @enum.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @enum.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @enum.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
