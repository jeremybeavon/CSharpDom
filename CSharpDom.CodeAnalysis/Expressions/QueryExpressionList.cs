using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal sealed class QueryExpressionList : IList<IQueryExpressionWithCodeAnalysis>
    {
        private readonly IEnumerable<IList<IQueryExpressionWithCodeAnalysis>> enumerable;

        private enum ListOperationType
        {
            IndexOf,
            Insert,
            RemoveAt
        }

        internal QueryExpressionList(QueryFromExpressionWithCodeAnalysis expression)
        {

        }

        public IQueryExpressionWithCodeAnalysis this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => enumerable.Select(list => list.Count).Sum();

        public bool IsReadOnly => false;

        public void Add(IQueryExpressionWithCodeAnalysis item)
        {
            enumerable.Last().Add(item);
        }

        public void Clear()
        {
            enumerable.First().Clear();
        }

        public bool Contains(IQueryExpressionWithCodeAnalysis item)
        {
            return enumerable.Any(list => list.Contains(item));
        }

        public void CopyTo(IQueryExpressionWithCodeAnalysis[] array, int arrayIndex)
        {
            enumerable.SelectMany(list => list).ToArray().CopyTo(array, arrayIndex);
        }

        public IEnumerator<IQueryExpressionWithCodeAnalysis> GetEnumerator()
        {
            return enumerable.SelectMany(list => list).GetEnumerator();
        }

        public int IndexOf(IQueryExpressionWithCodeAnalysis item)
        {
            int startIndex = 0;
            foreach (IList<IQueryExpressionWithCodeAnalysis> list in enumerable)
            {
                int index = list.IndexOf(item);
                if (index >= 0)
                {
                    return startIndex + index;
                }

                startIndex += list.Count;
            }

            return -1;
        }

        public void Insert(int index, IQueryExpressionWithCodeAnalysis item)
        {
            ProcessIndex(index, (list, listIndex) => list.Insert(listIndex, item));
        }

        public bool Remove(IQueryExpressionWithCodeAnalysis item)
        {
            return enumerable.Any(list => list.Remove(item));
        }

        public void RemoveAt(int index)
        {
            ProcessIndex(index, (list, listIndex) => list.RemoveAt(listIndex));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void ReplaceList(IEnumerable<IQueryExpressionWithCodeAnalysis> value)
        {

        }

        private static IEnumerable<IQueryExpressionWithCodeAnalysis> GetExpressions(
            QueryFromExpressionWithCodeAnalysis expression)
        {
            yield break;
        }

        private static IEnumerable<IQueryExpressionWithCodeAnalysis> GetExpressions(QueryBodySyntax syntax)
        {
            yield break;
        }

        private void ProcessIndex(int index, Action<IList<IQueryExpressionWithCodeAnalysis>, int> action)
        {
            int endIndex = 0;
            foreach (IList<IQueryExpressionWithCodeAnalysis> list in enumerable)
            {
                int startIndex = endIndex + 1;
                endIndex += list.Count - 1;
                if (index <= endIndex)
                {
                    action(list, index - startIndex);
                }
            }
        }
    }
}
