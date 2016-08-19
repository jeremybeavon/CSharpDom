using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class DetachedParentWithId<TChild, TSyntax> : IHasChildWithId<TChild, TSyntax>
        where TChild : IHasId
    {
        private TSyntax syntax;

        public DetachedParentWithId(TSyntax syntax)
        {
            this.syntax = syntax;
        }

        public TSyntax GetChild(TChild child)
        {
            return syntax;
        }

        public void SetChild(TChild child, TSyntax syntax)
        {
            this.syntax = syntax;
        }
    }
}
