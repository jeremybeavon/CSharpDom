using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal interface IChildSyntaxList<TParentSyntax, TChildSyntax> : IList<TChildSyntax>
    {
        TParentSyntax Set(int index, TChildSyntax value);
    }
}
