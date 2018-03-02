using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using CSharpDom.Common.Editable;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AutoPropertyWithCodeAnalysis :
        EditableAutoProperty<
            AttributeGroupWithCodeAnalysis,
            IEditableBasicType,
            ITypeReferenceWithCodeAnalysis,
            AutoPropertyAccessorWithCodeAnalysis,
            IExpressionWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>
    {
        private readonly PropertyWithCodeAnalysis property;
        private readonly CachedExpressionNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> initialValue;

        internal AutoPropertyWithCodeAnalysis()
        {
            property = new PropertyWithCodeAnalysis();
            initialValue = new CachedExpressionNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                property.Node,
                syntax => syntax.Initializer?.Value,
                (parentSyntax, childSyntax) => parentSyntax.WithInitializer(childSyntax == null ? null : SyntaxFactory.EqualsValueClause(childSyntax)));
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

        public override IEditableBasicType DeclaringType
        {
            get { return property.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override AutoPropertyAccessorWithCodeAnalysis GetAccessor
        {
            get
            {
                AccessorWithCodeAnalysis accessor = property.GetAccessor;
                return accessor == null ? null : new AutoPropertyAccessorWithCodeAnalysis(accessor);
            }
            set { property.GetAccessor = value?.Accessor; }
        }

        public override IExpressionWithCodeAnalysis InitialValue
        {
            get { return initialValue.Value; }
            set { initialValue.Value = value; }
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

        public override AutoPropertyAccessorWithCodeAnalysis SetAccessor
        {
            get
            {
                AccessorWithCodeAnalysis accessor = property.SetAccessor;
                return accessor == null ? null : new AutoPropertyAccessorWithCodeAnalysis(accessor);
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
