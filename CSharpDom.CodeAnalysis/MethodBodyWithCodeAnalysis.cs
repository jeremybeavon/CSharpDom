using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class MethodBodyWithCodeAnalysis :
        EditableMethodBody<IStatementWithCodeAnalysis>,
        IHasSyntax<BlockSyntax>,
        IHasNode<BlockSyntax>
    {
        private readonly BlockStatementWithCodeAnalysis block;

        internal MethodBodyWithCodeAnalysis()
        {
            block = new BlockStatementWithCodeAnalysis();
        }

        public override IList<IStatementWithCodeAnalysis> Statements
        {
            get { return block.Statements; }
            set { block.Statements = value; }
        }

        public BlockSyntax Syntax
        {
            get { return Node.Syntax; }
            set { Node.Syntax = value; }
        }
        
        INode<BlockSyntax> IHasNode<BlockSyntax>.Node
        {
            get { return Node; }
        }

        private StatementNode<BlockStatementWithCodeAnalysis, BlockSyntax> Node => block.Node;
    }
}
