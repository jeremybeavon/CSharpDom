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
        private readonly IEnumerable<QueryBodyWithCodeAnalysis> queryBodies;
        private readonly IEnumerable<IQueryExpressionWithCodeAnalysis> enumerable;

        private enum ListOperationType
        {
            IndexOf,
            Insert,
            RemoveAt,
            Set
        }

        internal QueryExpressionList(QueryExpressionWithCodeAnalysis expression)
        {
            queryBodies = GetExpressions(expression.Body);
            enumerable = queryBodies.SelectMany(body => body.AllExpressions);
        }

        public IQueryEndExpressionWithCodeAnalysis EndExpression
        {
            get { return queryBodies.Last().EndExpression; }
            set { queryBodies.Last().EndExpression = value; }
        }

        public IQueryExpressionWithCodeAnalysis this[int index]
        {
            get { return enumerable.ElementAt(index); }
            set
            {
                //ProcessIndex(index, (list, listIndex) => list[index] = value);
            }
        }

        public int Count => queryBodies.Select(body => body.Expressions.Count + 1).Sum() - 1;

        public bool IsReadOnly => false;

        public void Add(IQueryExpressionWithCodeAnalysis item)
        {
            QueryBodyWithCodeAnalysis body = queryBodies.Last();
            if (item is IHasSyntax<QueryClauseSyntax>)
            {
                body.Expressions.Add(item);
            }

            body.ContinuationExpression = item;
            IQueryEndExpressionWithCodeAnalysis endExpression = body.EndExpression;
            body.IntoExpression.Body = new QueryBodyWithCodeAnalysis()
            {
                EndExpression = endExpression
            };
        }

        public void Clear()
        {
            QueryBodyWithCodeAnalysis body = queryBodies.First();
            IQueryEndExpressionWithCodeAnalysis endExpression = EndExpression;
            body.Expressions.Clear();
            body.IntoExpression = null;
            body.EndExpression = endExpression;
        }

        public bool Contains(IQueryExpressionWithCodeAnalysis item)
        {
            return enumerable.Contains(item);
        }

        public void CopyTo(IQueryExpressionWithCodeAnalysis[] array, int arrayIndex)
        {
            enumerable.ToArray().CopyTo(array, arrayIndex);
        }

        public IEnumerator<IQueryExpressionWithCodeAnalysis> GetEnumerator()
        {
            return enumerable.GetEnumerator();
        }

        public int IndexOf(IQueryExpressionWithCodeAnalysis item)
        {
            int index = 0;
            foreach (IQueryExpressionWithCodeAnalysis expression in enumerable)
            {
                if (expression == item)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public void Insert(int index, IQueryExpressionWithCodeAnalysis item)
        {
            //ProcessIndex(index, (list, listIndex) => list.Insert(listIndex, item));
        }

        public bool Remove(IQueryExpressionWithCodeAnalysis item)
        {
            return false;
            //return queryBodies.Any(list => list.Remove(item));
        }

        public void RemoveAt(int index)
        {
            //ProcessIndex(index, (list, listIndex) => list.RemoveAt(listIndex));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void ReplaceList(IEnumerable<IQueryExpressionWithCodeAnalysis> value)
        {

        }
        
        private static IEnumerable<QueryBodyWithCodeAnalysis> GetExpressions(QueryBodyWithCodeAnalysis body)
        {
            yield return body;
            if (body.ContinuationExpression != null)
            {
                foreach (QueryBodyWithCodeAnalysis childBody in GetExpressions(body.IntoExpression.Body))
                {
                    yield return body;
                }
            }
        }

        private static IEnumerable<IQueryExpressionWithCodeAnalysis> GetExpressions(
            IEnumerable<QueryBodyWithCodeAnalysis> bodies)
        {
            foreach (QueryBodyWithCodeAnalysis body in bodies)
            {
                foreach (IQueryExpressionWithCodeAnalysis expression in body.Expressions)
                {
                    yield return expression;
                }


            }
        }

        private void ProcessIndex(int index, Action<QueryBodyWithCodeAnalysis, int> action)
        {
            int endIndex = -1;
            //QueryBodyWithCodeAnalysis currentBody;
            foreach (QueryBodyWithCodeAnalysis body in queryBodies)
            {
                int startIndex = endIndex + 1;
                endIndex += body.Expressions.Count;
                if (body.ContinuationExpression != null)
                {
                    endIndex++;
                }
                if (index <= endIndex)
                {
                    action(body, index - startIndex);
                    return;
                }
            }
        }
    }
}
