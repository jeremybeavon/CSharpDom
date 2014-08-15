using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;

namespace CSharpDom.WithSyntax
{
    public sealed class ClassWithSyntax : TypeWithSyntax
    {
        private readonly IClassSyntax @class;

        public ClassWithSyntax(IClassSyntax @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<ClassDeclarationWithSyntax> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassDeclarationWithSyntax, IClassDeclarationSyntax>(
                    @class.Declarations,
                    declaration => new ClassDeclarationWithSyntax(declaration));
            }    
        }

        public DestructorWithSyntax Destructor
        {
            get { return new DestructorWithSyntax(@class.Destructor); }
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

        public NamespaceWithSyntax Namespace
        {
            get { return new NamespaceWithSyntax(@class.Namespace); }
        }

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@class.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@class.Solution); }
        }

        public IClassSyntax AsInterface()
        {
            return @class;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @class.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitClass(this);
        }
    }
}
