using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal interface IHasNode<TSyntax>
        where TSyntax : class
    {
        INode<TSyntax> Node { get; }
    }
}
