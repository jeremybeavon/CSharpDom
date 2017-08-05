using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedStaticClassWithCodeAnalysis :
        EditableStructNestedStaticClass<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            NestedStaticClassEventCollectionWithCodeAnalysis,
            NestedStaticClassPropertyWithCodeAnalysis,
            NestedStaticClassMethodCollectionWithCodeAnalysis,
            NestedStaticClassFieldCollectionWithCodeAnalysis,
            NestedStaticClassNestedClassCollectionWithCodeAnalysis,
            NestedStaticClassNestedDelegateWithCodeAnalysis,
            NestedStaticClassNestedEnumWithCodeAnalysis,
            NestedStaticClassNestedInterfaceWithCodeAnalysis,
            NestedStaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        INestedStaticTypeWithCodeAnalysis,
        IHasNode<ClassDeclarationSyntax>
    {
        private readonly NestedStaticClassWithCodeAnalysis classType;

        public StructNestedStaticClassWithCodeAnalysis(StructMemberVisibilityModifier visibility, string name)
            : this()
        {
            Syntax = ClassDeclarationSyntaxExtensions.ToSyntax(name, visibility, SyntaxKind.StaticKeyword);
        }

        internal StructNestedStaticClassWithCodeAnalysis(NestedStaticClassWithCodeAnalysis type = null)
        {
            classType = type ?? new InternalNestedStaticClassWithCodeAnalysis<StructNestedStaticClassWithCodeAnalysis>(this);
        }

        public NestedStaticClassWithCodeAnalysis Class
        {
            get { return classType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override NestedStaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? classType.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<NestedStaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override ICollection<NestedStaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override NestedStaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override NestedStaticClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<NestedStaticClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override NestedStaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override ICollection<NestedStaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override NestedStaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }

        INode<ClassDeclarationSyntax> IHasNode<ClassDeclarationSyntax>.Node => classType.Node;

        internal Func<IStructTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}