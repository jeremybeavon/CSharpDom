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
        AbstractInterfaceProperty<AttributeGroupNotSupported, IBasicType, ReadOnlyTypeReference, ReadOnlyInterfaceAccessor>
    {
        private readonly InterfaceProperty interfaceProperty;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyInterfaceAccessor getAccessor;
        private readonly ReadOnlyInterfaceAccessor setAccessor;

        public ReadOnlyInterfaceProperty(InterfaceProperty interfaceProperty)
        {
            this.interfaceProperty = interfaceProperty;
            propertyType = new ReadOnlyTypeReference(interfaceProperty.Type);
            if (interfaceProperty.GetAccessor != null)
            {
                getAccessor = new ReadOnlyInterfaceAccessor();
            }

            if (interfaceProperty.SetAccessor != null)
            {
                setAccessor = new ReadOnlyInterfaceAccessor();
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
        
        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                return interfaceProperty.IsNew ? InterfaceMemberInheritanceModifier.New : InterfaceMemberInheritanceModifier.None;
            }
        }

        public override string Name
        {
            get { return interfaceProperty.Name; }
        }

        public override ReadOnlyTypeReference PropertyType
        {
            get { return propertyType; }
        }

        public override ReadOnlyInterfaceAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override ReadOnlyInterfaceAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public static IReadOnlyCollection<ReadOnlyInterfaceProperty> Create(IEnumerable<InterfaceProperty> interfaceProperties)
        {
            return interfaceProperties.ToArray(interfaceProperty => new ReadOnlyInterfaceProperty(interfaceProperty));
        }
    }
}
