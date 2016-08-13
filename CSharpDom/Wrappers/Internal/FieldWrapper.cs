using System;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class FieldWrapper : AbstractWrapper<IField>, IFieldWrapper
    {
        public FieldWrapper(IField field)
            : base(field)
        {
        }

        public IExpression InitialValue
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

        public override void VisitField<TExpression>(IField<TExpression> field)
        {
        }
    }
}
