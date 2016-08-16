using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class AbstractNode<TDeclaration, TContainer> : AbstractNode,
        IHasDeclaration<TDeclaration>, IHasSyntaxNode, IHasLocation
        where TDeclaration : SyntaxNode
    {
        private int? startLine;
        private int? endLine;

        protected AbstractNode(TDeclaration declaration, TContainer container)
        {
            Declaration = declaration;
            Container = container;
        }

        public TDeclaration Declaration { get; private set; }

        public TContainer Container { get; private set; }

        public int StartLine
        {
            get { return startLine ?? (int)(startLine = LineHelper.GetStartLine(Declaration)); }
        }

        public int EndLine
        {
            get { return endLine ?? (int)(endLine = LineHelper.GetEndLine(Declaration)); }
        }

        public SyntaxNode SyntaxNode
        {
            get { return Declaration; }
        }
    }
}
