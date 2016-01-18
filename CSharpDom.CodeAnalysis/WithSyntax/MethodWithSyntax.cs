using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class MethodWithSyntax : AbstractSyntaxNode<IMethodSyntax>
    {
        private readonly IMethodSyntax method;

        public MethodWithSyntax(IMethodSyntax method)
            : base(method)
        {
            this.method = method;
        }

        public MethodDeclarationSyntax Declaration
        {
            get { return method.Declaration; }
        }

        public BasicTypeWithSyntax DeclaringType
        {
            get { return BasicTypeWithSyntax.GetBasicType(method.DeclaringType); }
        }

        public int EndLine
        {
            get { return method.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return method.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return method.IsGeneric; }
        }

        public string Name
        {
            get { return method.Name; }
        }

        public int StartLine
        {
            get { return method.StartLine; }
        }

        public IMethodSyntax AsInterface()
        {
            return method;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            method.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitMethod(this);
        }
    }
}
