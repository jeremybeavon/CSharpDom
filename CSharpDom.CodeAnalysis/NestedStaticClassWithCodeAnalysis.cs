using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedStaticClassWithCodeAnalysis :
        EditableNestedStaticClass<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            NestedStaticClassMethodCollectionWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceCollectionWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly StaticTypeWithCodeAnalysis classType;

        internal NestedStaticClassWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedStaticClassWithCodeAnalysis @class)
        {
            classType = new StaticTypeWithCodeAnalysis(parent, @class);
        }

        internal NestedStaticClassWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedStaticClassWithCodeAnalysis @class)
        {
            classType = new StaticTypeWithCodeAnalysis(parent, @class);
        }

        internal NestedStaticClassWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedStaticClassWithCodeAnalysis @class)
        {
            classType = new StaticTypeWithCodeAnalysis(parent, @class);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return classType.Attributes; }
            set { classType.Attributes = value; }
        }

        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classType.Classes; }
            set { classType.Classes = value; }
        }

        public override IType DeclaringType
        {
            get { return classType.Node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<StaticClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return classType.Delegates; }
            set { classType.Delegates = value; }
        }
        
        public override ICollection<StaticClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return classType.Enums; }
            set { classType.Enums = value; }
        }

        public override StaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return classType.Events; }
            set { classType.Events = value; }
        }

        public override StaticClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return classType.Fields; }
            set { classType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return classType.GenericParameters; }
            set { classType.GenericParameters = value; }
        }
        
        public override StaticClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return classType.Interfaces; }
            set { classType.Interfaces = value; }
        }

        public override NestedStaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return new NestedStaticClassMethodCollectionWithCodeAnalysis(classType.Methods); }
            set { classType.Methods.Methods = value.Methods; }
        }

        public override string Name
        {
            get { return classType.Name; }
            set { classType.Name = value; }
        }
        
        public override ICollection<StaticClassPropertyWithCodeAnalysis> Properties
        {
            get { return classType.Properties; }
            set { classType.Properties = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return classType.StaticConstructor; }
            set { classType.StaticConstructor = value; }
        }

        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return classType.Structs; }
            set { classType.Structs = value; }
        }

        public ClassDeclarationSyntax Syntax
        {
            get { return classType.Syntax; }
            set { classType.Syntax = value; }
        }

        internal StaticTypeWithCodeAnalysis Class
        {
            get { return classType; }
        }
    }
}