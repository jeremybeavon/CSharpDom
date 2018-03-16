using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class AutoPropertyWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        AbstractAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>,
        IWrapper<IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TAccessor : IAutoPropertyAccessor
        where TExpression : IExpression
    {
        public AutoPropertyWrapper(IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
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

        public override TAccessor GetAccessor
        {
            get { return WrappedObject.GetAccessor; }
        }

        public override TExpression InitialValue => WrappedObject.InitialValue;

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public override TTypeReference PropertyType
        {
            get { return WrappedObject.PropertyType; }
        }

        public override TAccessor SetAccessor
        {
            get { return WrappedObject.SetAccessor; }
        }

        public IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> WrappedObject { get; private set; }
    }
}
