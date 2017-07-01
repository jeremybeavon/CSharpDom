using CSharpDom.Common;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class StructTypeWithMonoCecil :
        TypeWithMonoCecil<
            ITypeWithMonoCecil,
            StructEventCollectionWithMonoCecil,
            StructEventWithMonoCecil,
            StructEventPropertyWithMonoCecil,
            StructPropertyCollectionWithMonoCecil,
            StructPropertyWithMonoCecil,
            StructIndexerCollectionWithMonoCecil,
            StructIndexerWithMonoCecil,
            StructMethodCollectionWithMonoCecil,
            StructMethodWithMonoCecil,
            StructFieldCollectionWithMonoCecil,
            StructFieldWithMonoCecil,
            StructConstantWithMonoCecil,
            StructConstructorWithMonoCecil,
            StructNestedClassCollectionWithMonoCecil,
            StructNestedAbstractClassWithMonoCecil,
            StructNestedClassWithMonoCecil,
            StructNestedSealedClassWithMonoCecil,
            StructNestedStaticClassWithMonoCecil,
            StructNestedDelegateWithMonoCecil,
            StructNestedEnumWithMonoCecil,
            StructNestedInterfaceWithMonoCecil,
            StructNestedStructCollectionWithMonoCecil,
            StructNestedStructWithMonoCecil>
    {
        private readonly StructNestedClassCollectionWithMonoCecil classes;
        private readonly StructEventCollectionWithMonoCecil events;
        private readonly StructFieldCollectionWithMonoCecil fields;
        private readonly StructIndexerCollectionWithMonoCecil indexers;
        private readonly StructMethodCollectionWithMonoCecil methods;
        private readonly StructPropertyCollectionWithMonoCecil properties;
        private readonly StructNestedStructCollectionWithMonoCecil structs;

        public StructTypeWithMonoCecil(ITypeWithMonoCecil declaringType)
            : base(declaringType)
        {
            classes = new StructNestedClassCollectionWithMonoCecil(this);
            events = new StructEventCollectionWithMonoCecil(this);
            fields = new StructFieldCollectionWithMonoCecil(this);
            indexers = new StructIndexerCollectionWithMonoCecil(this);
            methods = new StructMethodCollectionWithMonoCecil(this);
            properties = new StructPropertyCollectionWithMonoCecil(this);
            structs = new StructNestedStructCollectionWithMonoCecil(this);
        }

        public override StructNestedClassCollectionWithMonoCecil Classes
        {
            get { return classes; }
        }

        public override StructEventCollectionWithMonoCecil Events
        {
            get { return events; }
        }

        public override StructFieldCollectionWithMonoCecil Fields
        {
            get { return fields; }
        }

        public override StructIndexerCollectionWithMonoCecil Indexers
        {
            get { return indexers; }
        }
        
        public override StructMethodCollectionWithMonoCecil Methods
        {
            get { return methods; }
        }

        public override StructPropertyCollectionWithMonoCecil Properties
        {
            get { return properties; }
        }

        public override StructNestedStructCollectionWithMonoCecil Structs
        {
            get { return structs; }
        }

        protected override StructConstantWithMonoCecil CreateConstant(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            return new StructConstantWithMonoCecil(declaringType, field);
        }

        protected override StructConstructorWithMonoCecil CreateConstructor(ITypeWithMonoCecil declaringType, MethodDefinition constructor)
        {
            return new StructConstructorWithMonoCecil(declaringType, constructor);
        }

        protected override StructEventWithMonoCecil CreateEvent(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            return new StructEventWithMonoCecil(declaringType, @event);
        }

        protected override StructEventPropertyWithMonoCecil CreateEventProperty(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            return new StructEventPropertyWithMonoCecil(declaringType, @event);
        }

        protected override StructFieldWithMonoCecil CreateField(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            return new StructFieldWithMonoCecil(declaringType, field);
        }

        protected override StructIndexerWithMonoCecil CreateIndexer(ITypeWithMonoCecil declaringType, PropertyDefinition indexer)
        {
            return new StructIndexerWithMonoCecil(declaringType, indexer);
        }

        protected override StructMethodWithMonoCecil CreateMethod(ITypeWithMonoCecil declaringType, MethodDefinition method)
        {
            return new StructMethodWithMonoCecil(declaringType, method);
        }

        protected override StructNestedAbstractClassWithMonoCecil CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedAbstractClassWithMonoCecil(declaringType, type);
        }

        protected override StructNestedClassWithMonoCecil CreateNestedClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedClassWithMonoCecil(declaringType, type);
        }

        protected override StructNestedDelegateWithMonoCecil CreateNestedDelegate(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedDelegateWithMonoCecil(declaringType, type);
        }

        protected override StructNestedEnumWithMonoCecil CreateNestedEnum(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedEnumWithMonoCecil(declaringType, type);
        }

        protected override StructNestedInterfaceWithMonoCecil CreateNestedInterface(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedInterfaceWithMonoCecil(declaringType, type);
        }

        protected override StructNestedSealedClassWithMonoCecil CreateNestedSealedClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedSealedClassWithMonoCecil(declaringType, type);
        }

        protected override StructNestedStaticClassWithMonoCecil CreateNestedStaticClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedStaticClassWithMonoCecil(declaringType, type);
        }

        protected override StructNestedStructWithMonoCecil CreateNestedStruct(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StructNestedStructWithMonoCecil(declaringType, type);
        }

        protected override StructPropertyWithMonoCecil CreateProperty(ITypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            return new StructPropertyWithMonoCecil(declaringType, property);
        }
    }
}
