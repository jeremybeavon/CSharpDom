using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class LabelTargets
    {
        private readonly IDictionary<string, LabelTarget> labelTargets;

        public LabelTargets()
        {
            labelTargets = new Dictionary<string, LabelTarget>();
        }

        public LabelTarget GetLabelTarget(string name)
        {
            LabelTarget target;
            if (!labelTargets.TryGetValue(name, out target))
            {
                target = Expression.Label(name);
                labelTargets.Add(name, target);
            }

            return target;
        }
    }
}
