using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal interface IHasParent<TChild, TSyntax>
        where TChild : IHasId
    {
        IHasChildWithId<TChild, TSyntax> Parent { get; set; }
    }
}
