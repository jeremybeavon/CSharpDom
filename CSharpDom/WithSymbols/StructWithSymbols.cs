using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public sealed class StructWithSymbols : TypeWithSymbols
    {
        private readonly IStructWithSymbols @struct;

        public StructWithSymbols(IStructWithSymbols @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<StructDeclarationWithSymbols> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<StructDeclarationWithSymbols, IStructDeclarationWithSymbols>(
                    @struct.Declarations,
                    declaration => new StructDeclarationWithSymbols(declaration));
            }
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
