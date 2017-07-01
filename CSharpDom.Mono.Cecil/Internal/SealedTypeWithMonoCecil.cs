using System;
using System.Reflection;
using CSharpDom.Common;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class SealedTypeWithMonoCecil :
        TypeWithMonoCecil<
            IInternalTypeWithMonoCecil,
            SealedClassEventCollectionWithMonoCecil,
            SealedClassEventWithMonoCecil,
            SealedClassEventPropertyWithMonoCecil,
            SealedClassPropertyCollectionWithMonoCecil,
            SealedClassPropertyWithMonoCecil,
            SealedClassIndexerCollectionWithMonoCecil,
            SealedClassIndexerWithMonoCecil,
            SealedClassMethodCollectionWithMonoCecil,
            SealedClassMethodWithMonoCecil,
            ClassFieldCollectionWithMonoCecil,
            ClassFieldWithMonoCecil,
            ClassConstantWithMonoCecil,
            ClassConstructorWithMonoCecil,
            ClassNestedClassCollectionWithMonoCecil,
            ClassNestedAbstractClassWithMonoCecil,
            ClassNestedClassWithMonoCecil,
            ClassNestedSealedClassWithMonoCecil,
            ClassNestedStaticClassWithMonoCecil,
            ClassNestedDelegateWithMonoCecil,
            ClassNestedEnumWithMonoCecil,
            ClassNestedInterfaceWithMonoCecil,
            ClassNestedStructCollectionWithMonoCecil,
            ClassNestedStructWithMonoCecil>
    {
        private readonly ClassNestedClassCollectionWithMonoCecil classes;
        private readonly SealedClassEventCollectionWithMonoCecil events;
        private readonly ClassFieldCollectionWithMonoCecil fields;
        private readonly SealedClassIndexerCollectionWithMonoCecil indexers;
        private readonly SealedClassMethodCollectionWithMonoCecil methods;
        private readonly SealedClassPropertyCollectionWithMonoCecil properties;
        private readonly ClassNestedStructCollectionWithMonoCecil structs;

        public SealedTypeWithMonoCecil(IInternalTypeWithMonoCecil declaringType)
            : base(declaringType)
        {
            classes = new ClassNestedClassCollectionWithMonoCecil(this);
            events = new SealedClassEventCollectionWithMonoCecil(this);
            fields = new ClassFieldCollectionWithMonoCecil(this);
            indexers = new SealedClassIndexerCollectionWithMonoCecil(this);
            methods = new SealedClassMethodCollectionWithMonoCecil(this);
            properties = new SealedClassPropertyCollectionWithMonoCecil(this);
            structs = new ClassNestedStructCollectionWithMonoCecil(this);
        }

        public override ClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return classes; }
        }

        public override SealedClassEventCollectionWithMonoCecil Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithMonoCecil Fields
        {
            get { return fields; }
        }

        public override SealedClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return indexers; }
        }
        
        public override SealedClassMethodCollectionWithMonoCecil Methods
        {
            get { return methods; }
        }

        public override SealedClassPropertyCollectionWithMonoCecil Properties
        {
            get { return properties; }
        }

        public override ClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return structs; }
        }

        protected override ClassConstantWithMonoCecil CreateConstant(IInternalTypeWithMonoCecil declaringType, FieldDefinition field)
        {
            return new ClassConstantWithMonoCecil(declaringType, field);
        }

        protected override ClassConstructorWithMonoCecil CreateConstructor(IInternalTypeWithMonoCecil declaringType, MethodDefinition constructor)
        {
            return new ClassConstructorWithMonoCecil(declaringType, constructor);
        }

        protected override SealedClassEventWithMonoCecil CreateEvent(IInternalTypeWithMonoCecil declaringType, EventDefinition @event)
        {
            return new SealedClassEventWithMonoCecil(declaringType, @event);
        }

        protected override SealedClassEventPropertyWithMonoCecil CreateEventProperty(
            IInternalTypeWithMonoCecil declaringType,
            EventDefinition @event)
        {
            return new SealedClassEventPropertyWithMonoCecil(declaringType, @event);
        }

        protected override ClassFieldWithMonoCecil CreateField(IInternalTypeWithMonoCecil declaringType, FieldDefinition field)
        {
            return new ClassFieldWithMonoCecil(declaringType, field);
        }

        protected override SealedClassIndexerWithMonoCecil CreateIndexer(IInternalTypeWithMonoCecil declaringType, PropertyDefinition indexer)
        {
            return new SealedClassIndexerWithMonoCecil(declaringType, indexer);
        }

        protected override SealedClassMethodWithMonoCecil CreateMethod(IInternalTypeWithMonoCecil declaringType, MethodDefinition method)
        {
            return new SealedClassMethodWithMonoCecil(declaringType, method);
        }

        protected override ClassNestedAbstractClassWithMonoCecil CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedAbstractClassWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedClassWithMonoCecil CreateNestedClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedClassWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedDelegateWithMonoCecil CreateNestedDelegate(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedDelegateWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedEnumWithMonoCecil CreateNestedEnum(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedEnumWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedInterfaceWithMonoCecil CreateNestedInterface(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedInterfaceWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedSealedClassWithMonoCecil CreateNestedSealedClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedSealedClassWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedStaticClassWithMonoCecil CreateNestedStaticClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedStaticClassWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedStructWithMonoCecil CreateNestedStruct(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new ClassNestedStructWithMonoCecil(declaringType, type);
        }

        protected override SealedClassPropertyWithMonoCecil CreateProperty(IInternalTypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            return new SealedClassPropertyWithMonoCecil(declaringType, property);
        }
    }
}
