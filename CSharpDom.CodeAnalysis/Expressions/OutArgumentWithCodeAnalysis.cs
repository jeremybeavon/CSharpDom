using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class OutArgumentWithCodeAnalysis :
        EditableOutArgument<IExpressionWithCodeAnalysis>,
        IHasSyntax<ArgumentSyntax>,
        IInternalArgument
    {
        private readonly ArgumentWithCodeAnalysis argument;

        public OutArgumentWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Syntax = SyntaxFactory.Argument(null, SyntaxFactory.Token(SyntaxKind.OutKeyword), expression.Syntax);
        }

        internal OutArgumentWithCodeAnalysis()
        {
            argument = new ArgumentWithCodeAnalysis();
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return argument.Expression; }
            set { argument.Expression = value; }
        }

        public override string Name { get => argument.Name; set => argument.Name = value; }

        public ArgumentSyntax Syntax
        {
            get { return argument.Syntax; }
            set { argument.Syntax = value; }
        }
        
        INode<ArgumentSyntax> IHasNode<ArgumentSyntax>.Node
        {
            get { return argument.Node; }
        }
    }
}
