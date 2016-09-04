using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class EmptySimpleMember : ISimpleMember
    {
        public T Member<T>()
        {
            throw new NotSupportedException();
        }
    }
}
