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
        public ReadOnlyStructBody(StructBody structBody)
        {
            Classes = structBody.NestedClasses.ToArray(nestedStruct => new ReadOnlyStructNestedClass(nestedStruct));
            Constructors = new ConstructorNotSupported[0];
            ConversionOperators = structBody.ConversionOperators
                .ToArray(conversionOperator => new ReadOnlyConversionOperator(conversionOperator));
            Delegates = structBody.NestedDelegates.ToArray(nestedDelegate => new ReadOnlyStructNestedDelegate(nestedDelegate));
            Enums = structBody.NestedEnums.ToArray(nestedEnum => new ReadOnlyStructNestedEnum(nestedEnum));
            List<ReadOnlyStructEvent> events = new List<ReadOnlyStructEvent>();
            List<ReadOnlyStructEvent> eventProperties = new List<ReadOnlyStructEvent>();
            Events = events;
            EventProperties = eventProperties;
            InitializeEvents(structBody, events, eventProperties);
            Fields = structBody.Fields.ToArray(field => new ReadOnlyStructFieldDeclaration(field));
            Indexers = structBody.Indexers.ToArray(indexer => new ReadOnlyStructIndexer(indexer));
            Interfaces = structBody.NestedInterfaces.ToArray(nestedInterface => new ReadOnlyStructNestedInterface(nestedInterface));
            Methods = structBody.Methods.ToArray(method => new ReadOnlyStructMethod(method));
            OperatorOverloads =
                structBody.BinaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator))
                .Concat(structBody.UnaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator)))
                .ToArray();
            Properties = structBody.Properties.ToArray(property => new ReadOnlyStructProperty(property));
            Structs = structBody.NestedStructs.ToArray(nestedStruct => new ReadOnlyStructNestedStruct(nestedStruct));

        }

        public IReadOnlyCollection<ReadOnlyStructNestedClass> Classes { get; private set; }

        public IReadOnlyCollection<ConstructorNotSupported> Constructors { get; private set; }

        public IReadOnlyCollection<ReadOnlyConversionOperator> ConversionOperators { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructNestedDelegate> Delegates { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructNestedEnum> Enums { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructEvent> EventProperties { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructEvent> Events { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructFieldDeclaration> Fields { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructIndexer> Indexers { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructNestedInterface> Interfaces { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructMethod> Methods { get; private set; }

        public IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructProperty> Properties { get; private set; }

        public IReadOnlyCollection<ReadOnlyStructNestedStruct> Structs { get; private set; }

        private void InitializeEvents(StructBody structBody, List<ReadOnlyStructEvent> events, List<ReadOnlyStructEvent> eventProperties)
        {
            foreach (StructEvent structEvent in structBody.Events)
            {
                ReadOnlyStructEvent @event = new ReadOnlyStructEvent(structEvent);
                if (@event.IsEventProperty)
                {
                    eventProperties.Add(@event);
                }
                else
                {
                    events.Add(@event);
                }
            }
        }
    }
}
