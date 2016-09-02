﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfacePropertyWithCodeAnalysis :
        EditableInterfaceProperty<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            InterfaceAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasId
    {
        private readonly PropertyWithCodeAnalysis property;
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IBasicType DeclaringType
        {
            get { return property.DeclaringType; }
            set { property.DeclaringType = value; }
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

        Guid IHasId.InternalId
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
