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
    public sealed class ReadOnlyStructBody :
        IType<
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
            ReadOnlyStructNestedInterfaceCollection,
            ReadOnlyStructNestedStructCollection,
            ReadOnlyStaticConstructor>
    {
        public ReadOnlyStructBody(StructBody structBody)
        {
            Classes = new ReadOnlyStructNestedClassCollection(structBody);
            Constructors = new ConstructorNotSupported[0];
            ConversionOperators = structBody.ConversionOperators
                .ToArray(conversionOperator => new ReadOnlyConversionOperator(conversionOperator));
            Delegates = structBody.NestedDelegates.ToArray(nestedDelegate => new ReadOnlyStructNestedDelegate(nestedDelegate));
            Enums = structBody.NestedEnums.ToArray(nestedEnum => new ReadOnlyStructNestedEnum(nestedEnum));
            Events = new ReadOnlyStructEventCollection(structBody);
            Fields = new ReadOnlyStructFieldCollection(structBody);
            Indexers = new ReadOnlyStructIndexerCollection(structBody);
            Interfaces = new ReadOnlyStructNestedInterfaceCollection(structBody);
            Methods = new ReadOnlyStructMethodCollection(structBody);
            OperatorOverloads =
                structBody.BinaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator))
                .Concat(structBody.UnaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator)))
                .ToArray();
            Properties = new ReadOnlyStructPropertyCollection(structBody);
            Structs = new ReadOnlyStructNestedStructCollection(structBody);

        }

        public ReadOnlyStructNestedClassCollection Classes { get; private set; }

        public IReadOnlyCollection<ConstructorNotSupported> Constructors { get; private set; }

        public IReadOnlyCollection<ReadOnlyConversionOperator> ConversionOperators { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructNestedDelegate> Delegates { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructNestedEnum> Enums { get; private set; }
        
        public ReadOnlyStructEventCollection Events { get; private set; }
        
        public ReadOnlyStructFieldCollection Fields { get; private set; }

        public ReadOnlyStructIndexerCollection Indexers { get; private set; }

        public ReadOnlyStructNestedInterfaceCollection Interfaces { get; private set; }

        public ReadOnlyStructMethodCollection Methods { get; private set; }

        public IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads { get; private set; }

        public ReadOnlyStructPropertyCollection Properties { get; private set; }

        public ReadOnlyStaticConstructor StaticConstructor { get; set; }

        public ReadOnlyStructNestedStructCollection Structs { get; private set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitType(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitTypeChildren(this, visitor);
        }
    }
}
