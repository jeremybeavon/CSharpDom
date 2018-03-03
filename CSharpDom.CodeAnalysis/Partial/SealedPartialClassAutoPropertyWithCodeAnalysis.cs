using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassAutoPropertyWithCodeAnalysis :
        EditableSealedClassAutoProperty<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ClassAutoPropertyAccessorWithCodeAnalysis,
            IExpressionWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly SealedClassAutoPropertyWithCodeAnalysis property;

        internal SealedPartialClassAutoPropertyWithCodeAnalysis(SealedClassAutoPropertyWithCodeAnalysis property)
        {
            this.property = property;
            property.DeclaringTypeFunc = () => DeclaringType.Class;
        }
           
        public SealedClassAutoPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Property.Property.Node.GetParent<ISealedPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ClassAutoPropertyAccessorWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
            set { property.GetAccessor = value; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.InheritanceModifier; }
            set { property.InheritanceModifier = value; }
        }

        public override IExpressionWithCodeAnalysis InitialValue
        {
            get => property.InitialValue;
            set => property.InitialValue = value;
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

        public override ClassAutoPropertyAccessorWithCodeAnalysis SetAccessor
        {
            get { return property.SetAccessor; }
            set { property.SetAccessor = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
            set { property.Visibility = value; }
        }
        
        INode<PropertyDeclarationSyntax> IHasNode<PropertyDeclarationSyntax>.Node
        {
            get { return property.Property.Property.Property.Node; }
        }
    }
}
