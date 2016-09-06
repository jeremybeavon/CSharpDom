using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfacePropertyWithCodeAnalysis :
        EditableExplicitInterfaceProperty<
            AttributeGroupWithCodeAnalysis,
            IType,
            InterfaceReferenceWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            AccessorWithBodyWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly PropertyWithBodyWithCodeAnalysis property;
        private readonly CachedChildNode<
            PropertyWithCodeAnalysis,
            PropertyDeclarationSyntax,
            InterfaceReferenceWithCodeAnalysis,
            NameSyntax> explicitInterface;

        internal ExplicitInterfacePropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            property = new PropertyWithBodyWithCodeAnalysis(parent, this);
        }

        internal ExplicitInterfacePropertyWithCodeAnalysis(StructTypeWithCodeAnalysis parent)
            : this()
        {
            property = new PropertyWithBodyWithCodeAnalysis(parent, this);
        }

        private ExplicitInterfacePropertyWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            explicitInterface = new CachedChildNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax, InterfaceReferenceWithCodeAnalysis, NameSyntax>(
                property.Node,
                parent => new InterfaceReferenceWithCodeAnalysis(parent),
                (parentSyntax, childSyntax) => parentSyntax.WithExplicitInterfaceSpecifier(parentSyntax.ExplicitInterfaceSpecifier.WithName(childSyntax)),
                (child, parent) => child.TypeReference.ExplicitInterfacePropertyParent = parent);
        }

        public PropertyWithBodyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override IType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface.Value; }
            set { explicitInterface.Value = value; }
        }

        public override AccessorWithBodyWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
            set { property.GetAccessor = value; }
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
            get { return property.SetAccessor; }
            set { property.SetAccessor = value; }
        }

        public PropertyDeclarationSyntax Syntax
        {
            get { return property.Syntax; }
            set { property.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
