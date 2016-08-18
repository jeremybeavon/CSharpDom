using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal interface IReplaceSyntaxList<TSyntax>
        where TSyntax : SyntaxNode
    {
        void ReplaceSyntaxList(SyntaxList<TSyntax> list);
    }
}
