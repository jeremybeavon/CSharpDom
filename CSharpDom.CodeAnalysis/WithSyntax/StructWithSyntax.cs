using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class StructWithSyntax : TypeWithSyntax
    {
        private readonly IStructSyntax @struct;

        public StructWithSyntax(IStructSyntax @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<StructDeclarationWithSyntax> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<StructDeclarationWithSyntax, IStructDeclarationSyntax>(
                    @struct.Declarations,
                    declaration => new StructDeclarationWithSyntax(declaration));
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

        public NamespaceWithSyntax Namespace
        {
            get { return new NamespaceWithSyntax(@struct.Namespace); }
        }

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@struct.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@struct.Solution); }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @struct.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitStruct(this);
        }
    }
}
