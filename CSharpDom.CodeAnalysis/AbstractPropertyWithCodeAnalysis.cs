using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractPropertyWithCodeAnalysis :
        AbstractAbstractProperty<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            AbstractAccessorWithCodeAnalysis>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly AbstractAccessorWithCodeAnalysis getAccessor;
        private readonly AbstractAccessorWithCodeAnalysis setAccessor;

        internal AbstractPropertyWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithCodeAnalysis(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new AbstractAccessorWithCodeAnalysis(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new AbstractAccessorWithCodeAnalysis(this, this.property.SetAccessor);
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

        public override AbstractAccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return property.PropertyType; }
        }

        public override AbstractAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyDefinition.ClassVisibility(); }
        }
    }
}
