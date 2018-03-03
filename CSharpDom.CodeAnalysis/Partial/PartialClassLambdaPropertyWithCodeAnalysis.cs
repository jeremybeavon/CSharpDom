using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassLambdaPropertyWithCodeAnalysis :
        EditableClassLambdaProperty<
            AttributeGroupWithCodeAnalysis,
            IPartialClassTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IExpressionWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly ClassLambdaPropertyWithCodeAnalysis property;

        internal PartialClassLambdaPropertyWithCodeAnalysis(ClassLambdaPropertyWithCodeAnalysis property)
        {
            this.property = property;
            property.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public ClassLambdaPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IPartialClassTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Property.Property.Node.GetParent<IPartialClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }
        
        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.InheritanceModifier; }
            set { property.InheritanceModifier = value; }
        }

        public override IExpressionWithCodeAnalysis LambdaExpression
        {
            get => property.LambdaExpression;
            set => property.LambdaExpression = value;
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
            get { return property.Property.Property.Node; }
        }
    }
}
