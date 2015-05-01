using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class StructWithLinqExpressions : TypeWithLinqExpressions
    {
        private readonly IStructWithLinqExpressions @struct;

        public StructWithLinqExpressions(IStructWithLinqExpressions @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<StructDeclarationWithLinqExpressions> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<StructDeclarationWithLinqExpressions, IStructDeclarationWithLinqExpressions>(
                    @struct.Declarations,
                    declaration => new StructDeclarationWithLinqExpressions(declaration));
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

        public NamespaceWithLinqExpressions Namespace
        {
            get { return new NamespaceWithLinqExpressions(@struct.Namespace); }
        }

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(@struct.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(@struct.Solution); }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @struct.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @struct.ToString();
        }
    }
}
