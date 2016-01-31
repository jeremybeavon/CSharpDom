using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructNestedStruct :
        AbstractNestedStruct<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyInterfaceReference,
            ReadOnlyStructEvent,
            ReadOnlyStructProperty,
            ReadOnlyStructIndexer,
            ReadOnlyStructMethod,
            ReadOnlyStructFieldDeclaration,
            ConstructorNotSupported,
            ReadOnlyStructEvent,
            ReadOnlyOperatorOverload,
            ReadOnlyConversionOperator,
            ReadOnlyStructNestedClass,
            ReadOnlyStructNestedDelegate,
            ReadOnlyStructNestedEnum,
            ReadOnlyStructNestedInterface,
            ReadOnlyStructNestedStruct>
    {
        private readonly StructNestedStruct nestedStruct;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyStructBody body;

        public ReadOnlyStructNestedStruct(StructNestedStruct nestedStruct)
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

        public override IReadOnlyCollection<ReadOnlyStructNestedClass> Classes
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

        public override IType DeclaringType
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

        public override IReadOnlyCollection<ReadOnlyStructEvent> EventProperties
        {
            get { return body.EventProperties; }
        }

        public override IReadOnlyCollection<ReadOnlyStructEvent> Events
        {
            get { return body.Events; }
        }

        public override IReadOnlyCollection<ReadOnlyStructFieldDeclaration> Fields
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

        public override IReadOnlyCollection<ReadOnlyStructIndexer> Indexers
        {
            get { return body.Indexers; }
        }

        public override IReadOnlyCollection<ReadOnlyStructNestedInterface> Interfaces
        {
            get { return body.Interfaces; }
        }

        public override bool IsPartial
        {
            get { return nestedStruct.IsPartial; }
        }

        public override IReadOnlyCollection<ReadOnlyStructMethod> Methods
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

        public override IReadOnlyCollection<ReadOnlyStructProperty> Properties
        {
            get { return body.Properties; }
        }

        public override IReadOnlyCollection<ReadOnlyStructNestedStruct> Structs
        {
            get { return body.Structs; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyStruct.GetVisibility(nestedStruct.Visibility); }
        }
    }
}
