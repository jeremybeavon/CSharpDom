using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStruct :
        AbstractStruct<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroupNotSupported,
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
        private readonly Struct @struct;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> implementedInterfaces;
        private readonly ReadOnlyStructBody body;

        public ReadOnlyStruct(Struct @struct)
        {
            this.@struct = @struct;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(@struct.GenericParameters);
            implementedInterfaces = ReadOnlyInterfaceReference.Create(@struct.Interfaces);
            body = new ReadOnlyStructBody(@struct.Body);
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

        public override IReadOnlyCollection<ReadOnlyStructNestedInterface> Interfaces
        {
            get { return body.Interfaces; }
        }
        
        public override ReadOnlyStructMethodCollection Methods
        {
            get { return body.Methods; }
        }

        public override string Name
        {
            get { return @struct.Name; }
        }

        public override NamespaceNotSupported Namespace
        {
            get { return new NamespaceNotSupported(); }
        }

        public override IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads
        {
            get { return body.OperatorOverloads; }
        }

        public override ReadOnlyStructPropertyCollection Properties
        {
            get { return body.Properties; }
        }

        public override ProjectNotSupported Project
        {
            get { return new ProjectNotSupported(); }
        }

        public override SolutionNotSupported Solution
        {
            get { return new SolutionNotSupported(); }
        }

        public override ReadOnlyStructNestedStructCollection Structs
        {
            get { return body.Structs; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return @struct.Visibility; }
        }
        
        public override ReadOnlyStaticConstructor StaticConstructor
        {
            get { return body.StaticConstructor; }
        }

        public override DocumentNotSupported Document
        {
            get { return new DocumentNotSupported(); }
        }
    }
}
