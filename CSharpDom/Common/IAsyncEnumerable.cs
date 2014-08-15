using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IAsyncEnumerable<T, TDocument>
    {
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> GetMultiple(Func<TDocument, bool> documentPredicate, Func<T, bool> predicate);

        Task<T> GetSingle(Func<TDocument, bool> documentPredicate, Func<T, bool> predicate);
    }
}
