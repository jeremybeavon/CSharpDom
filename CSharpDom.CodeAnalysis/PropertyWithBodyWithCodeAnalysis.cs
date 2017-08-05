using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class PropertyWithBodyWithCodeAnalysis :
        EditableProperty<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithBodyWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly PropertyWithCodeAnalysis property;

        internal PropertyWithBodyWithCodeAnalysis()
        {
            this.property = new PropertyWithCodeAnalysis();
        }
        
        public PropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IBasicType DeclaringType
        {
            get { return property.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override AccessorWithBodyWithCodeAnalysis GetAccessor
        {
            get
            {
                AccessorWithCodeAnalysis accessor = property.GetAccessor;
                return accessor == null ? null : new AccessorWithBodyWithCodeAnalysis(accessor);
            }
            set { property.GetAccessor = value?.Accessor; }
        }
        
        public override string Name
        {
            get { return property.Name; }
            set { property.Name = value; }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return property.PropertyType; }
            set { property.PropertyType = value; }
        }

        public override AccessorWithBodyWithCodeAnalysis SetAccessor
        {
            get
            {
                AccessorWithCodeAnalysis accessor = property.SetAccessor;
                return accessor == null ? null : new AccessorWithBodyWithCodeAnalysis(accessor);
            }
            set { property.SetAccessor = value?.Accessor; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }
    }
}
