using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal interface INode
    {
        IList<INode> ChildNodes { get; }

        void RefreshSyntax();
    }
}
