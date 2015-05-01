using System.Collections.Generic;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ClassWithLinqExpressions : TypeWithLinqExpressions
    {
        private readonly IClassWithLinqExpressions @class;

        public ClassWithLinqExpressions(IClassWithLinqExpressions @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<ClassDeclarationWithLinqExpressions> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassDeclarationWithLinqExpressions, IClassDeclarationWithLinqExpressions>(
                    @class.Declarations,
                    declaration => new ClassDeclarationWithLinqExpressions(declaration));
            }    
        }

        public DestructorWithLinqExpressions Destructor
        {
            get { return new DestructorWithLinqExpressions(@class.Destructor); }
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

        public NamespaceWithLinqExpressions Namespace
        {
            get { return new NamespaceWithLinqExpressions(@class.Namespace); }
        }

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(@class.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(@class.Solution); }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public IClassWithLinqExpressions AsInterface()
        {
            return @class;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @class.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @class.ToString();
        }
    }
}
