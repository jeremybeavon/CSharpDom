using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassNestedStaticPartialClassWithCodeAnalysis :
        EditableStaticClassNestedStaticPartialClass<
            AttributeGroupWithCodeAnalysis,
            INestedStaticPartialTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            NestedStaticPartialClassEventCollectionWithCodeAnalysis,
            NestedStaticPartialClassPropertyCollectionWithCodeAnalysis,
            NestedStaticPartialClassMethodCollectionWithCodeAnalysis,
            NestedStaticPartialClassFieldCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis,
            NestedStaticPartialClassNestedDelegateWithCodeAnalysis,
            NestedStaticPartialClassNestedEnumWithCodeAnalysis,
            NestedStaticPartialClassNestedInterfaceWithCodeAnalysis,
            NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>,
        INestedStaticPartialTypeWithCodeAnalysis
    {
        private readonly NestedStaticClassNestedStaticPartialClassWithCodeAnalysis classType;

        public NestedStaticPartialClassNestedStaticPartialClassWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this(new NestedStaticClassNestedStaticPartialClassWithCodeAnalysis(visibility, name))
        {
        }

        internal NestedStaticPartialClassNestedStaticPartialClassWithCodeAnalysis(
            NestedStaticClassNestedStaticPartialClassWithCodeAnalysis classType)
        {
            this.classType = classType;
            classType.DeclaringTypeFunc = () => DeclaringType.Class;
        }

        public NestedStaticClassNestedStaticPartialClassWithCodeAnalysis Class
        {
            get { return classType; }
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override NestedStaticPartialClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override INestedStaticPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return classType.Class.Class.Node.GetParent<INestedStaticPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<NestedStaticPartialClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }

        public override ICollection<NestedStaticPartialClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override NestedStaticPartialClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override NestedStaticPartialClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }

        public override ICollection<NestedStaticPartialClassNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override NestedStaticPartialClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return classType.Methods; }
            set { classType.Methods = value; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }

        public override NestedStaticPartialClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override NestedStaticPartialClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                ClassDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        INestedStaticTypeWithCodeAnalysis INestedStaticPartialTypeWithCodeAnalysis.Class => classType.Class;
    }
}