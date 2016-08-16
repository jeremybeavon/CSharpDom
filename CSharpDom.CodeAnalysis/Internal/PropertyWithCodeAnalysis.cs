using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class PropertyWithCodeAnalysis :
        AbstractProperty<AttributeGroupWithCodeAnalysis, ITypeWithCodeAnalysis, ITypeReferenceWithCodeAnalysis, AccessorWithCodeAnalysis>,
        IHasPropertyDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly PropertyDefinition property;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis propertyType;
        private readonly AccessorWithCodeAnalysis getAccessor;
        private readonly AccessorWithCodeAnalysis setAccessor;

        internal PropertyWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            this.declaringType = declaringType;
            this.property = property;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, property));
            propertyType = TypeReferenceWithCodeAnalysisFactory.CreateReference(declaringType.Assembly, property.PropertyType, property);
            if (property.GetMethod != null)
            {
                getAccessor = new AccessorWithCodeAnalysis(declaringType.Assembly, property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new AccessorWithCodeAnalysis(declaringType.Assembly, property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return propertyType; }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public PropertyDefinition PropertyDefinition
        {
            get { return property; }
        }
    }
}
