﻿using System;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStructWithCodeAnalysis<TStruct> :
        NestedStructWithCodeAnalysis
        where TStruct : class, IHasNode<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;

        internal InternalNestedStructWithCodeAnalysis(TStruct @struct)
        {
            structType = new InternalStructTypeWithCodeAnalysis<TStruct>(@struct);
        }
        
        public StructTypeWithCodeAnalysis Struct
        {
            get { return structType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return structType.Attributes; }
            set { structType.Attributes = value; }
        }
        
        public override StructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return structType.Classes; }
            set { structType.Classes = value; }
        }

        public override ICollection<StructConstructorWithCodeAnalysis> Constructors
        {
            get { return structType.Constructors; }
            set { structType.Constructors = value; }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return structType.ConversionOperators; }
            set { structType.ConversionOperators = value; }
        }

        public override ICollection<StructNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return structType.Delegates; }
            set { structType.Delegates = value; }
        }

        public override IType DeclaringType
        {
            get { return structType.Node.GetParent<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<StructNestedEnumWithCodeAnalysis> Enums
        {
            get { return structType.Enums; }
            set { structType.Enums = value; }
        }

        public override StructEventCollectionWithCodeAnalysis Events
        {
            get { return structType.Events; }
            set { structType.Events = value; }
        }

        public override StructFieldCollectionWithCodeAnalysis Fields
        {
            get { return structType.Fields; }
            set { structType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return structType.GenericParameters; }
            set { structType.GenericParameters = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return structType.ImplementedInterfaces; }
            set { structType.ImplementedInterfaces = value; }
        }

        public override StructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return structType.Indexers; }
            set { structType.Indexers = value; }
        }

        public override ICollection<StructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return structType.Interfaces; }
            set { structType.Interfaces = value; }
        }

        public override StructMethodCollectionWithCodeAnalysis Methods
        {
            get { return structType.Methods; }
            set { structType.Methods = value; }
        }

        public override string Name
        {
            get { return structType.Name; }
            set { structType.Name = value; }
        }

        public override ICollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return structType.OperatorOverloads; }
            set { structType.OperatorOverloads = value; }
        }

        public override StructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return structType.Properties; }
            set { structType.Properties = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return structType.StaticConstructor; }
            set { structType.StaticConstructor = value; }
        }

        public override StructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structType.Structs; }
            set { structType.Structs = value; }
        }

        public override StructDeclarationSyntax Syntax
        {
            get { return structType.Syntax; }
            set { structType.Syntax = value; }
        }

        internal InternalStructTypeWithCodeAnalysis<TStruct> InternalStruct
        {
            get { return structType; }
        }

        internal override INode<StructDeclarationSyntax> Node => structType.Node;

        internal override IMemberList Members => structType.Members;
    }
}
