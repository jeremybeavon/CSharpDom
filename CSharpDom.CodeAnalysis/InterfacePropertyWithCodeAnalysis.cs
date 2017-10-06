using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfacePropertyWithCodeAnalysis :
        EditableInterfaceProperty<
            AttributeGroupWithCodeAnalysis,
            IInterfaceTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            InterfaceAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly PropertyWithCodeAnalysis property;

        internal InterfacePropertyWithCodeAnalysis()
        {
            property = new PropertyWithCodeAnalysis();
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

        public override IInterfaceTypeWithCodeAnalysis DeclaringType
        {
            get { return property.Node.GetParentNode<IInterfaceTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override InterfaceAccessorWithCodeAnalysis GetAccessor
        {
            get { return new InterfaceAccessorWithCodeAnalysis(property.GetAccessor); }
            set { property.GetAccessor = value?.Accessor; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToInterfaceMemberInheritanceModifier(); }
            set { Syntax = Syntax.WithModifiers(value.ToTokens()); }
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

        public override InterfaceAccessorWithCodeAnalysis SetAccessor
        {
            get { return new InterfaceAccessorWithCodeAnalysis(property.SetAccessor); }
            set { property.SetAccessor = value?.Accessor; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }
        
        INode<PropertyDeclarationSyntax> IHasNode<PropertyDeclarationSyntax>.Node
        {
            get { return property.Node; }
        }
    }
}
