using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class NestedDestructorWithSyntax : AbstractSyntaxNode<INestedDestructorSyntax>
    {
        private readonly INestedDestructorSyntax destructor;

        public NestedDestructorWithSyntax(INestedDestructorSyntax destructor)
            : base(destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public NestedClassDeclarationWithSyntax DeclaringType
        {
            get { return new NestedClassDeclarationWithSyntax(destructor.DeclaringType); }
        }

        public int EndLine
        {
            get { return destructor.EndLine; }
        }

        public int StartLine
        {
            get { return destructor.StartLine; }
        }

        public INestedDestructorSyntax AsInterface()
        {
            return destructor;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            destructor.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedDestructor(this);
        }
    }
}
