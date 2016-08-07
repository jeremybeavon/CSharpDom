using System;
using System.Reflection;
using CSharpDom.Common;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class ClassTypeWithMonoCecil :
        TypeWithMonoCecil<
            IInternalTypeWithMonoCecil,
            ClassEventCollectionWithMonoCecil,
            ClassEventWithMonoCecil,
            ClassEventPropertyWithMonoCecil,
            ClassPropertyCollectionWithMonoCecil,
            ClassPropertyWithMonoCecil,
            ClassIndexerCollectionWithMonoCecil,
            ClassIndexerWithMonoCecil,
            ClassMethodCollectionWithMonoCecil,
            ClassMethodWithMonoCecil,
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
            ClassNestedInterfaceCollectionWithMonoCecil,
            ClassNestedInterfaceWithMonoCecil,
            ClassNestedStructCollectionWithMonoCecil,
            ClassNestedStructWithMonoCecil>
    {
        private readonly ClassNestedClassCollectionWithMonoCecil classes;
        private readonly ClassEventCollectionWithMonoCecil events;
        private readonly ClassFieldCollectionWithMonoCecil fields;
        private readonly ClassIndexerCollectionWithMonoCecil indexers;
        private readonly ClassNestedInterfaceCollectionWithMonoCecil interfaces;
        private readonly ClassMethodCollectionWithMonoCecil methods;
        private readonly ClassPropertyCollectionWithMonoCecil properties;
        private readonly ClassNestedStructCollectionWithMonoCecil structs;

        public ClassTypeWithMonoCecil(IInternalTypeWithMonoCecil declaringType)
            : base(declaringType)
        {
            classes = new ClassNestedClassCollectionWithMonoCecil(this);
            events = new ClassEventCollectionWithMonoCecil(this);
            fields = new ClassFieldCollectionWithMonoCecil(this);
            indexers = new ClassIndexerCollectionWithMonoCecil(this);
            interfaces = new ClassNestedInterfaceCollectionWithMonoCecil(this);
            methods = new ClassMethodCollectionWithMonoCecil(this);
            properties = new ClassPropertyCollectionWithMonoCecil(this);
            structs = new ClassNestedStructCollectionWithMonoCecil(this);
        }

        public override ClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return classes; }
        }

        public override ClassEventCollectionWithMonoCecil Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithMonoCecil Fields
        {
            get { return fields; }
        }

        public override ClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return interfaces; }
        }

        public override ClassMethodCollectionWithMonoCecil Methods
        {
            get { return methods; }
        }

        public override ClassPropertyCollectionWithMonoCecil Properties
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

        protected override ClassEventWithMonoCecil CreateEvent(IInternalTypeWithMonoCecil declaringType, EventDefinition @event)
        {
            return new ClassEventWithMonoCecil(declaringType, @event);
        }

        protected override ClassEventPropertyWithMonoCecil CreateEventProperty(
            IInternalTypeWithMonoCecil declaringType,
            EventDefinition @event)
        {
            return new ClassEventPropertyWithMonoCecil(declaringType, @event);
        }

        protected override ClassFieldWithMonoCecil CreateField(IInternalTypeWithMonoCecil declaringType, FieldDefinition field)
        {
            return new ClassFieldWithMonoCecil(declaringType, field);
        }

        protected override ClassIndexerWithMonoCecil CreateIndexer(IInternalTypeWithMonoCecil declaringType, PropertyDefinition indexer)
        {
            return new ClassIndexerWithMonoCecil(declaringType, indexer);
        }

        protected override ClassMethodWithMonoCecil CreateMethod(IInternalTypeWithMonoCecil declaringType, MethodDefinition method)
        {
            return new ClassMethodWithMonoCecil(declaringType, method);
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

        protected override ClassPropertyWithMonoCecil CreateProperty(IInternalTypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            return new ClassPropertyWithMonoCecil(declaringType, property);
        }
    }
}
