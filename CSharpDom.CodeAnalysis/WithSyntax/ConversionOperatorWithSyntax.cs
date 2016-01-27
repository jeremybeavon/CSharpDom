using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public sealed class ConversionOperatorWithSyntax : AbstractSyntaxNode<IConversionOperatorSyntax>
    {
        private readonly IConversionOperatorSyntax conversionOperator;

        public ConversionOperatorWithSyntax(IConversionOperatorSyntax conversionOperator)
            : base(conversionOperator)
        {
            this.conversionOperator = conversionOperator;
        }

        public ConversionOperatorDeclarationSyntax Declaration
        {
            get { return conversionOperator.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(conversionOperator.DeclaringType); }
        }

        public int EndLine
        {
            get { return conversionOperator.EndLine; }
        }

        public int StartLine
        {
            get { return conversionOperator.StartLine; }
        }

        public IConversionOperatorSyntax AsInterface()
        {
            return conversionOperator;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            conversionOperator.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitConversionOperator(this);
        }
    }
}
