using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class DestructorWithSyntax : AbstractSyntaxNode<IDestructorSyntax>
    {
        private readonly IDestructorSyntax destructor;

        public DestructorWithSyntax(IDestructorSyntax destructor)
            : base(destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public ClassDeclarationWithSyntax DeclaringType
        {
            get { return new ClassDeclarationWithSyntax(destructor.DeclaringType); }
        }

        public int EndLine
        {
            get { return destructor.EndLine; }
        }

        public int StartLine
        {
            get { return destructor.StartLine; }
        }

        public IDestructorSyntax AsInterface()
        {
            return destructor;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            destructor.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitDestructor(this);
        }
    }
}
