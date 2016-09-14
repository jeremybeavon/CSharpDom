using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class SimpleChildCollection<TChild, TSyntax, TSyntaxSubClass> : IChildCollection<TChild, TSyntaxSubClass>
        where TSyntaxSubClass : TSyntax
    {
        private readonly IChildCollection<TChild, TSyntax> childCollection;

        public SimpleChildCollection(IChildCollection<TChild, TSyntax> childCollection)
        {
            this.childCollection = childCollection;
        }

        public TSyntaxSubClass GetChild(TChild child)
        {
            return (TSyntaxSubClass)childCollection.GetChild(child);
        }

        public void SetChild(TChild child, TSyntaxSubClass syntax)
        {
            childCollection.SetChild(child, syntax);
        }
    }
}
