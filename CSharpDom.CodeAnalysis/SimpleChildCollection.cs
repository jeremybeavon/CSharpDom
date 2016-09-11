using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class SimpleChildCollection<TChild, TSyntax> : IChildCollection<TChild, TSyntax>
    {
        private readonly Func<TChild, TSyntax> getChild;
        private readonly Action<TChild, TSyntax> setChild;

        public SimpleChildCollection(Func<TChild, TSyntax> getChild, Action<TChild, TSyntax> setChild)
        {
            this.getChild = getChild;
            this.setChild = setChild;
        }

        public TSyntax GetChild(TChild child)
        {
            return getChild(child);
        }

        public void SetChild(TChild child, TSyntax syntax)
        {
            setChild(child, syntax);
        }
    }
}
