using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class StructWithSymbols : TypeWithSymbols
    {
        private readonly IStructWithSymbols @struct;

        public StructWithSymbols(IStructWithSymbols @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }
        
        public int GenericParameterCount
        {
            get { return @struct.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @struct.IsGeneric; }
        }

        public string Name
        {
            get { return @struct.Name; }
        }

        public NamespaceWithSymbols Namespace
        {
            get { return new NamespaceWithSymbols(@struct.Namespace); }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@struct.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@struct.Solution); }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @struct.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
