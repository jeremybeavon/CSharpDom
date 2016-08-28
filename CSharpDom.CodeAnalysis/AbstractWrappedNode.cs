using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class AbstractWrappedNode<TValue, TSyntax> : Node<TValue, TSyntax>
        where TSyntax : class
    {
        protected AbstractWrappedNode(TValue value)
            : base(value)
        {
        }

        public abstract void SetParentNode<TParentNode, TParentSyntax>(TParentNode parent);
    }
}
