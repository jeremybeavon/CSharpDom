using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class StructDeclarationWithSyntax : TypeWithSyntax
    {
        private IStructDeclarationSyntax @struct;

        public StructDeclarationWithSyntax(IStructDeclarationSyntax @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public StructWithSyntax CompositeType
        {
            get { return new StructWithSyntax(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public DocumentWithSyntax Document
        {
            get { return new DocumentWithSyntax(@struct.Document); }
        }

        public int EndLine
        {
            get { return @struct.EndLine; }
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

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@struct.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@struct.Solution); }
        }

        public int StartLine
        {
            get { return @struct.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @struct.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitStructDeclaration(this);
        }
    }
}
