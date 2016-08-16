using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Reflection;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class StructTypeWithCodeAnalysis :
        TypeWithCodeAnalysis<
            ITypeWithCodeAnalysis,
            StructEventCollectionWithCodeAnalysis,
            StructEventWithCodeAnalysis,
            StructEventPropertyWithCodeAnalysis,
            StructPropertyCollectionWithCodeAnalysis,
            StructPropertyWithCodeAnalysis,
            StructIndexerCollectionWithCodeAnalysis,
            StructIndexerWithCodeAnalysis,
            StructMethodCollectionWithCodeAnalysis,
            StructMethodWithCodeAnalysis,
            StructFieldCollectionWithCodeAnalysis,
            StructFieldWithCodeAnalysis,
            StructConstantWithCodeAnalysis,
            StructConstructorWithCodeAnalysis,
            StructNestedClassCollectionWithCodeAnalysis,
            StructNestedAbstractClassWithCodeAnalysis,
            StructNestedClassWithCodeAnalysis,
            StructNestedSealedClassWithCodeAnalysis,
            StructNestedStaticClassWithCodeAnalysis,
            StructNestedDelegateWithCodeAnalysis,
            StructNestedEnumWithCodeAnalysis,
            StructNestedInterfaceCollectionWithCodeAnalysis,
            StructNestedInterfaceWithCodeAnalysis,
            StructNestedStructCollectionWithCodeAnalysis,
            StructNestedStructWithCodeAnalysis>
    {
        private readonly StructNestedClassCollectionWithCodeAnalysis classes;
        private readonly StructEventCollectionWithCodeAnalysis events;
        private readonly StructFieldCollectionWithCodeAnalysis fields;
        private readonly StructIndexerCollectionWithCodeAnalysis indexers;
        private readonly StructNestedInterfaceCollectionWithCodeAnalysis interfaces;
        private readonly StructMethodCollectionWithCodeAnalysis methods;
        private readonly StructPropertyCollectionWithCodeAnalysis properties;
        private readonly StructNestedStructCollectionWithCodeAnalysis structs;

        public StructTypeWithCodeAnalysis(ITypeWithCodeAnalysis declaringType)
            : base(declaringType)
        {
            classes = new StructNestedClassCollectionWithCodeAnalysis(this);
            events = new StructEventCollectionWithCodeAnalysis(this);
            fields = new StructFieldCollectionWithCodeAnalysis(this);
            indexers = new StructIndexerCollectionWithCodeAnalysis(this);
            interfaces = new StructNestedInterfaceCollectionWithCodeAnalysis(this);
            methods = new StructMethodCollectionWithCodeAnalysis(this);
            properties = new StructPropertyCollectionWithCodeAnalysis(this);
            structs = new StructNestedStructCollectionWithCodeAnalysis(this);
        }

        public override StructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
        }

        public override StructEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
        }

        public override StructFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
        }

        public override StructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
        }

        public override StructNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return interfaces; }
        }

        public override StructMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
        }

        public override StructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
        }

        public override StructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
        }

        protected override StructConstantWithCodeAnalysis CreateConstant(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            return new StructConstantWithCodeAnalysis(declaringType, field);
        }

        protected override StructConstructorWithCodeAnalysis CreateConstructor(ITypeWithCodeAnalysis declaringType, MethodDefinition constructor)
        {
            return new StructConstructorWithCodeAnalysis(declaringType, constructor);
        }

        protected override StructEventWithCodeAnalysis CreateEvent(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            return new StructEventWithCodeAnalysis(declaringType, @event);
        }

        protected override StructEventPropertyWithCodeAnalysis CreateEventProperty(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            return new StructEventPropertyWithCodeAnalysis(declaringType, @event);
        }

        protected override StructFieldWithCodeAnalysis CreateField(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            return new StructFieldWithCodeAnalysis(declaringType, field);
        }

        protected override StructIndexerWithCodeAnalysis CreateIndexer(ITypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            return new StructIndexerWithCodeAnalysis(declaringType, indexer);
        }

        protected override StructMethodWithCodeAnalysis CreateMethod(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            return new StructMethodWithCodeAnalysis(declaringType, method);
        }

        protected override StructNestedAbstractClassWithCodeAnalysis CreateNestedAbstractClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedAbstractClassWithCodeAnalysis(declaringType, type);
        }

        protected override StructNestedClassWithCodeAnalysis CreateNestedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedClassWithCodeAnalysis(declaringType, type);
        }

        protected override StructNestedDelegateWithCodeAnalysis CreateNestedDelegate(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedDelegateWithCodeAnalysis(declaringType, type);
        }

        protected override StructNestedEnumWithCodeAnalysis CreateNestedEnum(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedEnumWithCodeAnalysis(declaringType, type);
        }

        protected override StructNestedInterfaceWithCodeAnalysis CreateNestedInterface(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedInterfaceWithCodeAnalysis(declaringType, type);
        }

        protected override StructNestedSealedClassWithCodeAnalysis CreateNestedSealedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedSealedClassWithCodeAnalysis(declaringType, type);
        }

        protected override StructNestedStaticClassWithCodeAnalysis CreateNestedStaticClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedStaticClassWithCodeAnalysis(declaringType, type);
        }

        protected override StructNestedStructWithCodeAnalysis CreateNestedStruct(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StructNestedStructWithCodeAnalysis(declaringType, type);
        }

        protected override StructPropertyWithCodeAnalysis CreateProperty(ITypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            return new StructPropertyWithCodeAnalysis(declaringType, property);
        }
    }
}
