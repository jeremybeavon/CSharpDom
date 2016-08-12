using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NamedAttributeValueWrapper : AbstractWrapper<INamedAttributeValue>, INamedAttributeValueWrapper
    {
        private Func<string> name;
        private Func<IExpression> value;

        public NamedAttributeValueWrapper(INamedAttributeValue namedAttributeValue)
            : base(namedAttributeValue)
        {
        }

        public string Name
        {
            get { return name(); }
        }

        public IExpression Value
        {
            get { return value(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void VisitNamedAttributeValue<TExpression>(INamedAttributeValue<TExpression> namedAttributeValue)
        {
            name = () => namedAttributeValue.Name;
            value = () => namedAttributeValue.Value;
        }
    }
}
