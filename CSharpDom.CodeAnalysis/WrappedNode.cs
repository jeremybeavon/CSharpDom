using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class WrappedNode<TValue, TSyntax, TWrapper> : AbstractWrappedNode<TValue, TSyntax>
        where TSyntax : class
    {
        public WrappedNode(TValue value)
            : base(value)
        {

        }

        public override void SetParentNode<TParentNode, TParentSyntax>(TParentNode parent)
        {
            throw new NotImplementedException();
        }
    }
}
