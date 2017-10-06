using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassPropertyWithCodeAnalysis :
        EditableSealedClassProperty<
            AttributeGroupWithCodeAnalysis,
            ISealedTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<PropertyDeclarationSyntax>,
        IHasNode<PropertyDeclarationSyntax>
    {
        private readonly ClassPropertyWithCodeAnalysis property;

        public SealedClassPropertyWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            MethodBodyWithCodeAnalysis getAccessor,
            MethodBodyWithCodeAnalysis setAccessor)
            : this(new ClassPropertyWithCodeAnalysis(visibility, type, name, getAccessor, setAccessor))
        {
        }

        internal SealedClassPropertyWithCodeAnalysis(ClassPropertyWithCodeAnalysis property = null)
        {
            this.property = property ?? new ClassPropertyWithCodeAnalysis();
            this.property.DeclaringTypeFunc = () => DeclaringType.Class;
        }
           
        public ClassPropertyWithCodeAnalysis Property
        {
            get { return property; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return property.Attributes; }
            set { property.Attributes = value; }
        }

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? property.Property.Property.Node.GetParentNode<ISealedTypeWithCodeAnalysis>(); }
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
        
        INode<PropertyDeclarationSyntax> IHasNode<PropertyDeclarationSyntax>.Node
        {
            get { return property.Property.Property.Node; }
        }

        internal Func<ISealedTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
