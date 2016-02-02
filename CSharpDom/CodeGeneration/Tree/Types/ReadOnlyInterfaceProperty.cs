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
        AbstractInterfaceProperty<AttributeGroupNotSupported, IBasicType, ReadOnlyTypeReference>
    {
        private readonly InterfaceProperty interfaceProperty;
        private readonly ReadOnlyTypeReference propertyType;

        public ReadOnlyInterfaceProperty(InterfaceProperty interfaceProperty)
        {
            this.interfaceProperty = interfaceProperty;
            propertyType = new ReadOnlyTypeReference(interfaceProperty.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override bool HasGet
        {
            get
            {
                InterfacePropertyAccessors accessors = interfaceProperty.Accessors;
                return accessors == InterfacePropertyAccessors.Get || accessors == InterfacePropertyAccessors.GetAndSet;
            }
        }

        public override bool HasSet
        {
            get
            {
                InterfacePropertyAccessors accessors = interfaceProperty.Accessors;
                return accessors == InterfacePropertyAccessors.Set || accessors == InterfacePropertyAccessors.GetAndSet;
            }
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
        
        public static IReadOnlyCollection<ReadOnlyInterfaceProperty> Create(IEnumerable<InterfaceProperty> interfaceProperties)
        {
            return interfaceProperties.ToArray(interfaceProperty => new ReadOnlyInterfaceProperty(interfaceProperty));
        }
    }
}
