using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassNestedStruct :
        AbstractStaticClassNestedStruct<
            AttributeGroupNotSupported,
            IStaticType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyInterfaceReference,
            ReadOnlyStructEventCollection,
            ReadOnlyStructPropertyCollection,
            ReadOnlyStructIndexerCollection,
            ReadOnlyStructMethodCollection,
            ReadOnlyStructFieldCollection,
            ConstructorNotSupported,
            ReadOnlyOperatorOverload,
            ReadOnlyConversionOperator,
            ReadOnlyStructNestedClassCollection,
            ReadOnlyStructNestedDelegate,
            ReadOnlyStructNestedEnum,
            ReadOnlyStructNestedInterface,
            ReadOnlyStructNestedStructCollection,
            ReadOnlyStaticConstructor>
    {
        private readonly StaticClassNestedStruct nestedStruct;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyStructBody body;

        public ReadOnlyStaticClassNestedStruct(StaticClassNestedStruct nestedStruct)
        {
            this.nestedStruct = nestedStruct;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(nestedStruct.GenericParameters);
            implementedInterfaces = ReadOnlyInterfaceReference.Create(nestedStruct.Interfaces);
            body = new ReadOnlyStructBody(nestedStruct.Body);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }
        
        public override ReadOnlyStructNestedClassCollection Classes
        {
            get { return body.Classes; }
        }

        public override IReadOnlyCollection<ConstructorNotSupported> Constructors
        {
            get { return body.Constructors; }
        }

        public override IReadOnlyCollection<ReadOnlyConversionOperator> ConversionOperators
        {
            get { return body.ConversionOperators; }
        }

        public override IStaticType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyCollection<ReadOnlyStructNestedDelegate> Delegates
        {
            get { return body.Delegates; }
        }

        public override IReadOnlyCollection<ReadOnlyStructNestedEnum> Enums
        {
            get { return body.Enums; }
        }
        
        public override ReadOnlyStructEventCollection Events
        {
            get { return body.Events; }
        }

        public override ReadOnlyStructFieldCollection Fields
        {
            get { return body.Fields; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceReference> ImplementedInterfaces
        {
            get { return implementedInterfaces; }
        }

        public override ReadOnlyStructIndexerCollection Indexers
        {
            get { return body.Indexers; }
        }

        public override ReadOnlyStructNestedInterface Interfaces
        {
            get { return body.Interfaces; }
        }
        
        public override ReadOnlyStructMethodCollection Methods
        {
            get { return body.Methods; }
        }

        public override string Name
        {
            get { return nestedStruct.Name; }
        }

        public override IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads
        {
            get { return body.OperatorOverloads; }
        }

        public override ReadOnlyStructPropertyCollection Properties
        {
            get { return body.Properties; }
        }

        public override ReadOnlyStructNestedStructCollection Structs
        {
            get { return body.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedStruct.Visibility; }
        }
        
        public override ReadOnlyStaticConstructor StaticConstructor
        {
            get { return body.StaticConstructor; }
        }
    }
}
