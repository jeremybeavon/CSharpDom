using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ObjectInitializersWithLinqExpressions : 
        IHasObjectInitializers<ILinqExpression, ObjectInitializersWithLinqExpressions>
    {
        private readonly IReadOnlyList<IReadOnlyList<ILinqExpression>> elements;
        private readonly IReadOnlyDictionary<string, ObjectInitializersWithLinqExpressions> initializers;
        private readonly IReadOnlyDictionary<string, ILinqExpression> members;

        public ObjectInitializersWithLinqExpressions(IEnumerable<MemberBinding> bindings)
        {
            List<IReadOnlyList<ILinqExpression>> elements = new List<IReadOnlyList<ILinqExpression>>();
            Dictionary<string, ObjectInitializersWithLinqExpressions> initializers =
                new Dictionary<string, ObjectInitializersWithLinqExpressions>();
            Dictionary<string, ILinqExpression> members = new Dictionary<string, ILinqExpression>();
            foreach (MemberBinding binding in bindings)
            {
                switch (binding.BindingType)
                {
                    case MemberBindingType.Assignment:
                        members.Add(
                            binding.Member.Name,
                            LinqExpressionBuilder.BuildExpression(((MemberAssignment)binding).Expression));
                        break;
                    case MemberBindingType.ListBinding:
                        elements.AddRange(LinqExpressionBuilder.BuildExpressions(((MemberListBinding)binding).Initializers));
                        break;
                    case MemberBindingType.MemberBinding:
                        initializers.Add(
                            binding.Member.Name,
                            new ObjectInitializersWithLinqExpressions(((MemberMemberBinding)binding).Bindings));
                        break;
                }
            }

            this.members = members;
            this.elements = elements;
            this.initializers = initializers;
        }

        public IReadOnlyList<IReadOnlyList<ILinqExpression>> Elements
        {
            get { return elements; }
        }

        public IReadOnlyDictionary<string, ObjectInitializersWithLinqExpressions> Initializers
        {
            get { return initializers; }
        }

        public IReadOnlyDictionary<string, ILinqExpression> Members
        {
            get { return members; }
        }
    }
}
