using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class UnnamedAttributeValueWrapper : AbstractWrapper<IUnnamedAttributeValue>, IUnnamedAttributeValueWrapper
    {
        private Func<IExpression> value;

        public UnnamedAttributeValueWrapper(IUnnamedAttributeValue unnamedAttributeValue)
            : base(unnamedAttributeValue)
        {
        }

        public IExpression Value
        {
            get { return value(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void VisitUnnamedAttributeValue<TExpression>(IUnnamedAttributeValue<TExpression> unnamedAttributeValue)
        {
            value = () => unnamedAttributeValue.Value;
        }
    }
}
