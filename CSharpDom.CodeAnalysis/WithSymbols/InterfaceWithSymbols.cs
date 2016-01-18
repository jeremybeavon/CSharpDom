using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class InterfaceWithSymbols : BasicTypeWithSymbols
    {
        private readonly IInterfaceWithSymbols @interface;

        public InterfaceWithSymbols(IInterfaceWithSymbols @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }
        
        public int GenericParameterCount
        {
            get { return @interface.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @interface.IsGeneric; }
        }

        public string Name
        {
            get { return @interface.Name; }
        }

        public NamespaceWithSymbols Namespace
        {
            get { return new NamespaceWithSymbols(@interface.Namespace); }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@interface.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@interface.Solution); }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @interface.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @interface.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
