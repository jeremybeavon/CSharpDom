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
    public sealed class ReadOnlyClassBody :
        IType<
            ReadOnlyClassEvent,
            ReadOnlyClassProperty,
            ReadOnlyClassIndexer,
            ReadOnlyClassMethod,
            ReadOnlyClassField,
            ConstructorNotSupported,
            ReadOnlyClassEvent,
            ReadOnlyOperatorOverload,
            ReadOnlyConversionOperator,
            ReadOnlyClassNestedClass,
            ReadOnlyClassNestedDelegate,
            ReadOnlyClassNestedEnum,
            ReadOnlyClassNestedInterface,
            ReadOnlyClassNestedStruct,
            ReadOnlyStaticConstructor,
            ReadOnlyExplicitInterfaceEvent,
            ReadOnlyExplicitInterfaceProperty,
            ReadOnlyExplicitInterfaceIndexer,
            ReadOnlyExplicitInterfaceMethod>
    {
        public ReadOnlyClassBody(ClassBody classBody)
        {
            Classes = classBody.NestedClasses.ToArray(nestedClass => new ReadOnlyClassNestedClass(nestedClass));
            Constructors = new ConstructorNotSupported[0];
            ConversionOperators = classBody.ConversionOperators
                .ToArray(conversionOperator => new ReadOnlyConversionOperator(conversionOperator));
            Delegates = classBody.NestedDelegates.ToArray(nestedDelegate => new ReadOnlyClassNestedDelegate(nestedDelegate));
            Enums = classBody.NestedEnums.ToArray(nestedEnum => new ReadOnlyClassNestedEnum(nestedEnum));
            List<ReadOnlyClassEvent> events = new List<ReadOnlyClassEvent>();
            List<ReadOnlyClassEvent> eventProperties = new List<ReadOnlyClassEvent>();
            Events = events;
            EventProperties = eventProperties;
            InitializeEvents(classBody, events, eventProperties);
            ExplicitInterfaceEvents = classBody.ExplicitInterfaceEvents.ToArray(@event => new ReadOnlyExplicitInterfaceEvent(@event));
            ExplicitInterfaceIndexers = classBody.ExplicitInterfaceIndexers.ToArray(indexer => new ReadOnlyExplicitInterfaceIndexer(indexer));
            ExplicitInterfaceMethods = classBody.ExplicitInterfaceMethods.ToArray(method => new ReadOnlyExplicitInterfaceMethod(method));
            ExplicitInterfaceProperties = classBody.ExplicitInterfaceProperties.ToArray(property => new ReadOnlyExplicitInterfaceProperty(property));
            Fields = classBody.Fields.ToArray(field => new ReadOnlyClassField(field));
            Indexers = classBody.Indexers.ToArray(indexer => new ReadOnlyClassIndexer(indexer));
            Interfaces = classBody.NestedInterfaces.ToArray(nestedInterface => new ReadOnlyClassNestedInterface(nestedInterface));
            Methods = classBody.Methods.ToArray(method => new ReadOnlyClassMethod(method));
            OperatorOverloads =
                classBody.BinaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator))
                .Concat(classBody.UnaryOperators.Select(@operator => new ReadOnlyOperatorOverload(@operator)))
                .ToArray();
            Properties = classBody.Properties.ToArray(property => new ReadOnlyClassProperty(property));
            if (classBody.StaticConstructor != null)
            {
                StaticConstructor = new ReadOnlyStaticConstructor(classBody.StaticConstructor);
            }

            Structs = classBody.NestedStructs.ToArray(nestedStruct => new ReadOnlyClassNestedStruct(nestedStruct));
        }

        public IReadOnlyCollection<ReadOnlyClassNestedClass> Classes { get; private set; }

        public IReadOnlyCollection<ConstructorNotSupported> Constructors { get; private set; }

        public IReadOnlyCollection<ReadOnlyConversionOperator> ConversionOperators { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassNestedDelegate> Delegates { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassNestedEnum> Enums { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassEvent> EventProperties { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassEvent> Events { get; private set; }

        public IReadOnlyCollection<ReadOnlyExplicitInterfaceEvent> ExplicitInterfaceEvents { get; private set; }

        public IReadOnlyCollection<ReadOnlyExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; private set; }

        public IReadOnlyCollection<ReadOnlyExplicitInterfaceMethod> ExplicitInterfaceMethods { get; private set; }

        public IReadOnlyCollection<ReadOnlyExplicitInterfaceProperty> ExplicitInterfaceProperties { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassField> Fields { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassIndexer> Indexers { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassNestedInterface> Interfaces { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassMethod> Methods { get; private set; }

        public IReadOnlyCollection<ReadOnlyOperatorOverload> OperatorOverloads { get; private set; }

        public IReadOnlyCollection<ReadOnlyClassProperty> Properties { get; private set; }

        public ReadOnlyStaticConstructor StaticConstructor { get; set; }

        public IReadOnlyCollection<ReadOnlyClassNestedStruct> Structs { get; private set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitType(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitTypeChildren(this, visitor);
        }

        private void InitializeEvents(ClassBody classBody, List<ReadOnlyClassEvent> events, List<ReadOnlyClassEvent> eventProperties)
        {
            foreach (ClassEvent classEvent in classBody.Events)
            {
                ReadOnlyClassEvent @event = new ReadOnlyClassEvent(classEvent);
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
