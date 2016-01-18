using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class InterfaceDeclarationWithSyntax : BasicTypeWithSyntax
    {
        private readonly IInterfaceDeclarationSyntax @interface;

        public InterfaceDeclarationWithSyntax(IInterfaceDeclarationSyntax @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public InterfaceWithSyntax CompositeType
        {
            get { return new InterfaceWithSyntax(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public DocumentWithSyntax Document
        {
            get { return new DocumentWithSyntax(@interface.Document); }
        }

        public int EndLine
        {
            get { return @interface.EndLine; }
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

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@interface.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@interface.Solution); }
        }

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @interface.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitInterfaceDeclaration(this);
        }
    }
}
