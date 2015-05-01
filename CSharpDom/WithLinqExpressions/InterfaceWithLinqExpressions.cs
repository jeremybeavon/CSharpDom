using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class InterfaceWithLinqExpressions : BasicTypeWithLinqExpressions
    {
        private readonly IInterfaceWithLinqExpressions @interface;

        public InterfaceWithLinqExpressions(IInterfaceWithLinqExpressions @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public IReadOnlyCollection<InterfaceDeclarationWithLinqExpressions> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<InterfaceDeclarationWithLinqExpressions, IInterfaceDeclarationWithLinqExpressions>(
                    @interface.Declarations,
                    declaration => new InterfaceDeclarationWithLinqExpressions(declaration));
            }
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

        public NamespaceWithLinqExpressions Namespace
        {
            get { return new NamespaceWithLinqExpressions(@interface.Namespace); }
        }

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(@interface.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(@interface.Solution); }
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @interface.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @interface.ToString();
        }
    }
}
