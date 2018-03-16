using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class LambdaPropertyWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        AbstractLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IWrapper<ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public LambdaPropertyWrapper(ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
        {
            WrappedObject = property;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override TExpression LambdaExpression => WrappedObject.LambdaExpression;

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public override TTypeReference PropertyType
        {
            get { return WrappedObject.PropertyType; }
        }
        
        public ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> WrappedObject { get; private set; }
    }
}
