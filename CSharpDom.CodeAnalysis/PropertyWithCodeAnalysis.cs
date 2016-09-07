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
    public sealed class PropertyWithCodeAnalysis :
        EditableProperty<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object property;
        private readonly Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> node;
        private readonly AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            PropertyWithCodeAnalysis,
            PropertyDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> propertyType;
        private readonly CachedChildNode<
            PropertyWithCodeAnalysis,
            PropertyDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> getAccessor;
        private readonly CachedChildNode<
            PropertyWithCodeAnalysis,
            PropertyDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> setAccessor;

        internal PropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, AbstractPropertyWithCodeAnalysis property)
            : this(property)
        {
            AbstractClassParent = parent;
        }

        internal PropertyWithCodeAnalysis(
            ClassTypeWithCodeAnalysis parent,
            ClassPropertyWithCodeAnalysis property,
            ClassType classType)
            : this(property)
        {
            SetClassParent(parent, classType);
        }

        internal PropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ExplicitInterfacePropertyWithCodeAnalysis property)
            : this(property)
        {
            ExplicitInterfaceClassParent = parent;
        }

        internal PropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassPropertyWithCodeAnalysis property)
            : this(property)
        {
            SealedClassParent = parent;
        }

        internal PropertyWithCodeAnalysis(InterfaceTypeWithCodeAnalysis parent, InterfacePropertyWithCodeAnalysis property)
            : this(property)
        {
            InterfaceParent = parent;
        }

        internal PropertyWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassPropertyWithCodeAnalysis property)
            : this(property)
        {
            StaticClassParent = parent;
        }

        internal PropertyWithCodeAnalysis(StructTypeWithCodeAnalysis parent, ExplicitInterfacePropertyWithCodeAnalysis property)
            : this(property)
        {
            ExplicitInterfaceStructParent = parent;
        }

        internal PropertyWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructPropertyWithCodeAnalysis property)
            : this(property)
        {
            StructParent = parent;
        }

        private PropertyWithCodeAnalysis(object property)
        {
            node = new Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(this);
            this.property = property;
            attributes = new AttributeListWrapper<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.PropertyParent = parent);
            propertyType = new CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax),
                parent => parent.Syntax.Type.ToTypeReference(),
                null);
            getAccessor = GetAccessorNode(SyntaxKind.GetKeyword);
            setAccessor = GetAccessorNode(SyntaxKind.SetKeyword);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IBasicType DeclaringType
        {
            get { return node.GetParentNode<IBasicType>(); }
            set { throw new NotSupportedException(); }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor.Value; }
            set { getAccessor.Value = value; }
        }
        
        public override string Name
        {
            get { return node.Syntax.Identifier.Text; }
            set { node.Syntax = node.Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ITypeReferenceWithCodeAnalysis PropertyType
        {
            get { return propertyType.Value; }
            set { propertyType.Value = value; }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor.Value; }
            set { setAccessor.Value = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal Node<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal ClassTypeWithCodeAnalysis AbstractClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.AbstractType.Properties.AbstractPropertyList);
            }
        }

        internal ClassTypeWithCodeAnalysis ExplicitInterfaceClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Properties.ExplicitInterfacePropertyList);
            }
        }

        internal StructTypeWithCodeAnalysis ExplicitInterfaceStructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.Properties.ExplicitInterfacePropertyList);
            }
        }

        internal InterfaceTypeWithCodeAnalysis InterfaceParent
        {
            get { return node.GetParentNode<InterfaceTypeWithCodeAnalysis>(); }
            set { node.SetParentNode<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(value, parent => parent.PropertyList); }
        }

        internal ClassTypeWithCodeAnalysis SealedClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.SealedType.Properties.PropertyList);
            }
        }

        internal StaticTypeWithCodeAnalysis StaticClassParent
        {
            get { return node.GetParentNode<StaticTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.PropertyList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.Properties.PropertyList);
            }
        }

        private CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax> GetAccessorNode(
            SyntaxKind kind)
        {
            return new CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => CreateAccessor(kind)(parentSyntax, childSyntax),
                parent => GetAccessorDeclaration(parent.Syntax, kind) == null ? null : new AccessorWithCodeAnalysis(this, kind),
                (child, parent) => child.PropertyParent = parent);
        }
        
        internal static Func<PropertyDeclarationSyntax, AccessorDeclarationSyntax, PropertyDeclarationSyntax> CreateAccessor(
            SyntaxKind kind)
        {
            return (PropertyDeclarationSyntax parentSyntax, AccessorDeclarationSyntax childSyntax) =>
                parentSyntax.WithAccessorList(parentSyntax.AccessorList.WithAccessor(childSyntax, kind));
        }

        internal static AccessorDeclarationSyntax GetAccessorDeclaration(PropertyDeclarationSyntax syntax, SyntaxKind kind)
        {
            return syntax.AccessorList.GetAccessorDeclaration(kind);
        }

        internal void SetClassParent(ClassTypeWithCodeAnalysis value, ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Normal:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Properties.PropertyList);
                    break;
                case ClassType.Abstract:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.AbstractType.Properties.PropertyList);
                    break;
            }
        }
        
        T ISimpleMember.Member<T>()
        {
            return (T)property;
        }
    }
}
