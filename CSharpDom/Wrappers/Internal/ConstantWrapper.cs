using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ConstantWrapper : AbstractWrapper<IConstant>, IConstantWrapper
    {
        public ConstantWrapper(IConstant @enum)
            : base(@enum)
        {
        }

        public IExpression ConstantValue
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitConstant<TExpression>(IConstant<TExpression> field)
        {

        }
    }
}
