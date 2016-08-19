using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal interface IHasChildWithId<TChild, TSyntax>
        where TChild : IHasId
    {
        TSyntax GetChild(TChild child);

        void SetChild(TChild child, TSyntax syntax);
    }
}
