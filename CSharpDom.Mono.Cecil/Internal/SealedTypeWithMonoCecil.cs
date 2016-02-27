using System;
using System.Reflection;
using CSharpDom.Common;

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
        private readonly SealedClassEventCollectionWithMonoCecil events;
        private readonly ClassFieldCollectionWithMonoCecil fields;
        private readonly SealedClassIndexerCollectionWithMonoCecil indexers;
        private readonly ClassNestedInterfaceCollectionWithMonoCecil interfaces;
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
            interfaces = new ClassNestedInterfaceCollectionWithMonoCecil(this);
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

        public override ClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return interfaces; }
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

        protected override ClassConstructorWithMonoCecil CreateConstructor(ITypeWithMonoCecil declaringType, ConstructorInfo constructor)
        {
            return new ClassConstructorWithMonoCecil(declaringType, constructor);
        }

        protected override SealedClassEventWithMonoCecil CreateEvent(IInternalTypeWithMonoCecil declaringType, EventInfo @event)
        {
            return new SealedClassEventWithMonoCecil(declaringType, @event);
        }

        protected override SealedClassEventPropertyWithMonoCecil CreateEventProperty(
            IInternalTypeWithMonoCecil declaringType,
            EventInfo @event)
        {
            return new SealedClassEventPropertyWithMonoCecil(declaringType, @event);
        }

        protected override ClassFieldWithMonoCecil CreateField(IInternalTypeWithMonoCecil declaringType, FieldInfo field)
        {
            return new ClassFieldWithMonoCecil(declaringType, field);
        }

        protected override SealedClassIndexerWithMonoCecil CreateIndexer(IInternalTypeWithMonoCecil declaringType, PropertyInfo indexer)
        {
            return new SealedClassIndexerWithMonoCecil(declaringType, indexer);
        }

        protected override SealedClassMethodWithMonoCecil CreateMethod(IInternalTypeWithMonoCecil declaringType, MethodInfo method)
        {
            return new SealedClassMethodWithMonoCecil(declaringType, method);
        }

        protected override ClassNestedAbstractClassWithMonoCecil CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedAbstractClassWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedClassWithMonoCecil CreateNestedClass(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedClassWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedDelegateWithMonoCecil CreateNestedDelegate(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedDelegateWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedEnumWithMonoCecil CreateNestedEnum(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedEnumWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedInterfaceWithMonoCecil CreateNestedInterface(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedInterfaceWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedSealedClassWithMonoCecil CreateNestedSealedClass(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedSealedClassWithMonoCecil((IInternalTypeWithMonoCecil)declaringType, type);
        }

        protected override ClassNestedStaticClassWithMonoCecil CreateNestedStaticClass(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedStaticClassWithMonoCecil(declaringType, type);
        }

        protected override ClassNestedStructWithMonoCecil CreateNestedStruct(ITypeWithMonoCecil declaringType, Type type)
        {
            return new ClassNestedStructWithMonoCecil(declaringType, type);
        }

        protected override SealedClassPropertyWithMonoCecil CreateProperty(IInternalTypeWithMonoCecil declaringType, PropertyInfo property)
        {
            return new SealedClassPropertyWithMonoCecil(declaringType, property);
        }
    }
}
