using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyInterfaceProperty :
        AbstractProperty<AttributeGroupNotSupported, IBasicType, ReadOnlyTypeReference, ReadOnlyInterfacePropertyAccessor>
    {
        private readonly InterfaceProperty interfaceProperty;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyInterfacePropertyAccessor getAccessor;
        private readonly ReadOnlyInterfacePropertyAccessor setAccessor;

        public ReadOnlyInterfaceProperty(InterfaceProperty interfaceProperty)
        {
            this.interfaceProperty = interfaceProperty;
            propertyType = new ReadOnlyTypeReference(interfaceProperty.Type);
            InterfacePropertyAccessors accessors = interfaceProperty.Accessors;
            if (accessors == InterfacePropertyAccessors.Get || accessors == InterfacePropertyAccessors.GetAndSet)
            {
                getAccessor = new ReadOnlyInterfacePropertyAccessor();
            }

            if (accessors == InterfacePropertyAccessors.Set || accessors == InterfacePropertyAccessors.GetAndSet)
            {
                setAccessor = new ReadOnlyInterfacePropertyAccessor();
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyInterfacePropertyAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override MemberInheritanceModifier InheritanceModifier
        {
            get { return interfaceProperty.IsNew ? MemberInheritanceModifier.New : MemberInheritanceModifier.None; }
        }

        public override string Name
        {
            get { return interfaceProperty.Name; }
        }

        public override ReadOnlyTypeReference PropertyType
        {
            get { return propertyType; }
        }

        public override ReadOnlyInterfacePropertyAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return MemberVisibilityModifier.None; }
        }

        public static IReadOnlyCollection<ReadOnlyInterfaceProperty> Create(IEnumerable<InterfaceProperty> interfaceProperties)
        {
            return interfaceProperties.ToArray(interfaceProperty => new ReadOnlyInterfaceProperty(interfaceProperty));
        }
    }
}
