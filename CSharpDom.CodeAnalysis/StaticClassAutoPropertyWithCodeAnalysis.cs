﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassAutoPropertyWithCodeAnalysis :
        EditableStaticClassAutoProperty<
            AttributeGroupWithCodeAnalysis,
            StaticClassWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            StaticClassAutoPropertyAccessorWithCodeAnalysis,
            IExpressionWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly AutoPropertyWithCodeAnalysis property;
        
        internal StaticClassAutoPropertyWithCodeAnalysis()
        {
            property = new AutoPropertyWithCodeAnalysis();
        }
        
        public AutoPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override StaticClassWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? property.Property.Node.GetParent<StaticClassWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override StaticClassAutoPropertyAccessorWithCodeAnalysis GetAccessor
        {
            get
            {
                AutoPropertyAccessorWithCodeAnalysis accessor = property.GetAccessor;
                return accessor == null ? null : new StaticClassAutoPropertyAccessorWithCodeAnalysis(accessor);
            }
            set { property.GetAccessor = value?.Accessor; }
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

        public override StaticClassAutoPropertyAccessorWithCodeAnalysis SetAccessor
        {
            get
            {
                AutoPropertyAccessorWithCodeAnalysis accessor = property.SetAccessor;
                return accessor == null ? null : new StaticClassAutoPropertyAccessorWithCodeAnalysis(accessor);
            }
            set { property.SetAccessor = value?.Accessor; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }
        
        INode<PropertyDeclarationSyntax> IHasNode<PropertyDeclarationSyntax>.Node
        {
            get { return property.Property.Node; }
        }

        internal Func<StaticClassWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
