using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassPropertyWithCodeAnalysis :
        AbstractSealedClassProperty<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly IInternalTypeWithCodeAnalysis declaringType;
        private readonly ClassAccessorWithCodeAnalysis getAccessor;
        private readonly ClassAccessorWithCodeAnalysis setAccessor;

        internal SealedClassPropertyWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithCodeAnalysis(declaringType, property);
            this.declaringType = declaringType;
            if (this.property.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithCodeAnalysis(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithCodeAnalysis(this, this.property.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.PropertyDefinition.SealedClassInheritanceModifier(declaringType); }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return property.PropertyType; }
        }

        public override ClassAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyDefinition.ClassVisibility(); }
        }
    }
}
