using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassPropertyWithCodeAnalysis :
        AbstractClassProperty<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly IInternalTypeWithCodeAnalysis declaringType;
        private readonly ClassAccessorWithCodeAnalysis getAccessor;
        private readonly ClassAccessorWithCodeAnalysis setAccessor;

        internal ClassPropertyWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, PropertyDefinition propertyInfo)
        {
            property = new PropertyWithCodeAnalysis(declaringType, propertyInfo);
            this.declaringType = declaringType;
            if (property.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithCodeAnalysis(this, property.GetAccessor);
            }

            if (property.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithCodeAnalysis(this, property.SetAccessor);
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

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.PropertyDefinition.InheritanceModifier(declaringType); }
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
