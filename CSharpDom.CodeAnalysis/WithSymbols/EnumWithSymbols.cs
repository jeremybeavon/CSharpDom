using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class EnumWithSymbols : AbstractSymbolNode<IEnumWithSymbols>
    {
        private readonly IEnumWithSymbols @enum;

        public EnumWithSymbols(IEnumWithSymbols @enum)
            : base(@enum)
        {
            this.@enum = @enum;
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
