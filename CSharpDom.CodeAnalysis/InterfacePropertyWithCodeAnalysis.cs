using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfacePropertyWithCodeAnalysis :
        AbstractInterfaceProperty<
            AttributeGroupWithCodeAnalysis,
            IBasicTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            InterfaceAccessorWithCodeAnalysis>
    {
        private readonly PropertyDefinition property;
        private readonly IBasicTypeWithCodeAnalysis declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis propertyType;
        private readonly InterfaceAccessorWithCodeAnalysis getAccessor;
        private readonly InterfaceAccessorWithCodeAnalysis setAccessor;

        internal InterfacePropertyWithCodeAnalysis(IBasicTypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            this.property = property;
            this.declaringType = declaringType;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, property));
            propertyType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, property.PropertyType, property);
            if (property.GetMethod != null)
            {
                getAccessor = new InterfaceAccessorWithCodeAnalysis(assembly, property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new InterfaceAccessorWithCodeAnalysis(assembly, property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override IBasicTypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override InterfaceAccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                if ((property.GetMethod ?? property.SetMethod).IsHideBySig)
                {
                    return InterfaceMemberInheritanceModifier.New;
                }

                return InterfaceMemberInheritanceModifier.None;
            }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return propertyType; }
        }

        public override InterfaceAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
