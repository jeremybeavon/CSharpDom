using System.Collections.Generic;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public sealed class ClassWithSymbols : TypeWithSymbols
    {
        private readonly IClassWithSymbols @class;

        public ClassWithSymbols(IClassWithSymbols @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<ClassDeclarationWithSymbols> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassDeclarationWithSymbols, IClassDeclarationWithSymbols>(
                    @class.Declarations,
                    declaration => new ClassDeclarationWithSymbols(declaration));
            }    
        }

        public DestructorWithSymbols Destructor
        {
            get { return new DestructorWithSymbols(@class.Destructor); }
        }

        public int GenericParameterCount
        {
            get { return @class.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @class.IsGeneric; }
        }

        public string Name
        {
            get { return @class.Name; }
        }

        public NamespaceWithSymbols Namespace
        {
            get { return new NamespaceWithSymbols(@class.Namespace); }
        }

        public ProjectWithSymbols Project
        {
            get { return ProjectWithSymbols.GetProject(@class.Project); }
        }

        public SolutionWithSymbols Solution
        {
            get { return SolutionWithSymbols.GetSolution(@class.Solution); }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public IClassWithSymbols AsInterface()
        {
            return @class;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @class.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
