using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class LoadedProjectMemberCollection<T> : IReadOnlyCollection<T>
    {
        private readonly IEnumerable<T> enumerable;

        public LoadedProjectMemberCollection(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public int Count => enumerable.Count();
        
        public IEnumerator<T> GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
