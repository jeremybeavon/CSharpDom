using CSharpDom.Common;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class ClassDeclarationWithSyntax : TypeWithSyntax, IHasLocation
    {
        private readonly IClassDeclarationSyntax @class;

        public ClassDeclarationWithSyntax(IClassDeclarationSyntax @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public ClassWithSyntax CompositeType
        {
            get { return new ClassWithSyntax(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public DestructorWithSyntax Destructor
        {
            get { return new DestructorWithSyntax(@class.Destructor); }
        }

        public DocumentWithSyntax Document
        {
            get { return new DocumentWithSyntax(@class.Document); }
        }

        public int EndLine
        {
            get { return @class.EndLine; }
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

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@class.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@class.Solution); }
        }

        public int StartLine
        {
            get { return @class.StartLine; }
        }

        public IClassDeclarationSyntax AsInterface()
        {
            return @class;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @class.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitClassDeclaration(this);
        }
    }
}
