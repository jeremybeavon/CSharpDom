using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassPropertyWithCodeAnalysis :
        EditableSealedClassProperty<
            AttributeGroupWithCodeAnalysis,
            ISealedType,
            ITypeReferenceWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly ClassPropertyWithCodeAnalysis property;
     
        internal SealedClassPropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            property = new ClassPropertyWithCodeAnalysis(parent, this);
        }
           
        private SealedClassPropertyWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        public PropertyWithBodyWithCodeAnalysis Property
        {
            get { return property.Property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override ISealedType DeclaringType
        {
            get { return property.Property.Property.Node.GetParentNode<ISealedType>(); }
            set { throw new NotSupportedException(); }
        }

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return property.GetAccessor; }
            set { property.GetAccessor = value; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToSealedClassMemberInheritanceModifier(); }
            set
            {
                PropertyDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithSealedClassMemberInheritanceModifier(value));
            }
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

        public override ClassAccessorWithCodeAnalysis SetAccessor
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
