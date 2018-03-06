using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class MethodBodyWithCodeAnalysis :
        EditableMethodBody<IStatementWithCodeAnalysis>,
        IHasSyntax<BlockSyntax>,
        IHasNode<BlockSyntax>
    {
        private readonly BlockStatementWithCodeAnalysis block;

        public MethodBodyWithCodeAnalysis(params IStatementWithCodeAnalysis[] statements)
            : this()
        {
            Syntax = SyntaxFactory.Block(statements.Select(statement => statement.Syntax));
        }

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
