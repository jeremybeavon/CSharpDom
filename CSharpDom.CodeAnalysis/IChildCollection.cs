using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public interface IChildCollection<TChild, TSyntax> : IList<TChild>
    {
        TSyntax GetChild(TChild child);

        void SetChild(TChild child, TSyntax syntax);
    }
}
