using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class DelegateWithSymbols : AbstractSymbolNode<IDelegateWithSymbols>
    {
        private readonly IDelegateWithSymbols @delegate;

        public DelegateWithSymbols(IDelegateWithSymbols @delegate)
            : base(@delegate)
        {
            this.@delegate = @delegate;
        }

        public DelegateDeclarationSyntax Declaration
        {
            get { return @delegate.Declaration; }
        }

        public int EndLine
        {
            get { return @delegate.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @delegate.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @delegate.IsGeneric; }
        }

        public string Name
        {
            get { return @delegate.Name; }
        }

        public NamespaceWithSymbols Namespace
        {
            get { return new NamespaceWithSymbols(@delegate.Namespace); }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@delegate.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@delegate.Solution); }
        }

        public int StartLine
        {
            get { return @delegate.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @delegate.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @delegate.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
