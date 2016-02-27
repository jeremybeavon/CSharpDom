using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class PropertyWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IWrapper<IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
        public PropertyWrapper(IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
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

        public IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> WrappedObject { get; private set; }
    }
}
