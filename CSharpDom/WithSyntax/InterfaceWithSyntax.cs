using System.Collections.Generic;
using CSharpDom.WithSyntax.Internal;

namespace CSharpDom.WithSyntax
{
    public sealed class InterfaceWithSyntax : BasicTypeWithSyntax
    {
        private readonly IInterfaceSyntax @interface;

        public InterfaceWithSyntax(IInterfaceSyntax @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public IReadOnlyCollection<InterfaceDeclarationWithSyntax> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<InterfaceDeclarationWithSyntax, IInterfaceDeclarationSyntax>(
                    @interface.Declarations,
                    declaration => new InterfaceDeclarationWithSyntax(declaration));
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

        public NamespaceWithSyntax Namespace
        {
            get { return new NamespaceWithSyntax(@interface.Namespace); }
        }

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@interface.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@interface.Solution); }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @interface.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitInterface(this);
        }
    }
}
