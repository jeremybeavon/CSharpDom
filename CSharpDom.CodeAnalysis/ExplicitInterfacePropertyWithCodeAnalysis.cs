using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfacePropertyWithCodeAnalysis :
        AbstractExplicitInterfaceProperty<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithCodeAnalysis>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly string name;
        private readonly InterfaceReferenceWithCodeAnalysis explicitInterface;

        internal ExplicitInterfacePropertyWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithCodeAnalysis(declaringType, property);
            name = property.Name.Split('.').Last();
            TypeReference interfaceType = property.Method().FindExplicitInterface();
            explicitInterface = new InterfaceReferenceWithCodeAnalysis(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return property.PropertyType; }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return property.SetAccessor; }
        }
    }
}
