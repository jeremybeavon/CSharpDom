using System;
using System.Reflection;
using CSharpDom.Common;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class StaticTypeWithMonoCecil :
        TypeWithMonoCecil<
            ITypeWithMonoCecil,
            StaticClassEventCollectionWithMonoCecil,
            StaticClassEventWithMonoCecil,
            StaticClassEventPropertyWithMonoCecil,
            StaticClassPropertyCollectionWithMonoCecil,
            StaticClassPropertyWithMonoCecil,
            IIndexerCollection,
            IIndexer,
            StaticClassMethodCollectionWithMonoCecil,
            StaticClassMethodWithMonoCecil,
            StaticClassFieldCollectionWithMonoCecil,
            StaticClassFieldWithMonoCecil,
            StaticClassConstantWithMonoCecil,
            IConstructor,
            StaticClassNestedClassCollectionWithMonoCecil,
            StaticClassNestedAbstractClassWithMonoCecil,
            StaticClassNestedClassWithMonoCecil,
            StaticClassNestedSealedClassWithMonoCecil,
            StaticClassNestedStaticClassWithMonoCecil,
            StaticClassNestedDelegateWithMonoCecil,
            StaticClassNestedEnumWithMonoCecil,
            StaticClassNestedInterfaceWithMonoCecil,
            StaticClassNestedStructCollectionWithMonoCecil,
            StaticClassNestedStructWithMonoCecil>
    {
        private readonly StaticClassNestedClassCollectionWithMonoCecil classes;
        private readonly StaticClassEventCollectionWithMonoCecil events;
        private readonly StaticClassFieldCollectionWithMonoCecil fields;
        private readonly StaticClassMethodCollectionWithMonoCecil methods;
        private readonly StaticClassPropertyCollectionWithMonoCecil properties;
        private readonly StaticClassNestedStructCollectionWithMonoCecil structs;

        public StaticTypeWithMonoCecil(ITypeWithMonoCecil declaringType)
            : base(declaringType)
        {
            classes = new StaticClassNestedClassCollectionWithMonoCecil(this);
            events = new StaticClassEventCollectionWithMonoCecil(this);
            fields = new StaticClassFieldCollectionWithMonoCecil(this);
            methods = new StaticClassMethodCollectionWithMonoCecil(this);
            properties = new StaticClassPropertyCollectionWithMonoCecil(this);
            structs = new StaticClassNestedStructCollectionWithMonoCecil(this);
        }

        public override StaticClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return classes; }
        }

        public override StaticClassEventCollectionWithMonoCecil Events
        {
            get { return events; }
        }

        public override StaticClassFieldCollectionWithMonoCecil Fields
        {
            get { return fields; }
        }

        public override IIndexerCollection Indexers
        {
            get { throw new NotSupportedException(); }
        }
        
        public override StaticClassMethodCollectionWithMonoCecil Methods
        {
            get { return methods; }
        }

        public override StaticClassPropertyCollectionWithMonoCecil Properties
        {
            get { return properties; }
        }

        public override StaticClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return structs; }
        }

        protected override StaticClassConstantWithMonoCecil CreateConstant(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            return new StaticClassConstantWithMonoCecil(declaringType, field);
        }

        protected override IConstructor CreateConstructor(ITypeWithMonoCecil declaringType, MethodDefinition constructor)
        {
            throw new NotSupportedException();
        }

        protected override StaticClassEventWithMonoCecil CreateEvent(ITypeWithMonoCecil declaringType, EventDefinition @event)
        {
            return new StaticClassEventWithMonoCecil(declaringType, @event);
        }

        protected override StaticClassEventPropertyWithMonoCecil CreateEventProperty(
            ITypeWithMonoCecil declaringType,
            EventDefinition @event)
        {
            return new StaticClassEventPropertyWithMonoCecil(declaringType, @event);
        }

        protected override StaticClassFieldWithMonoCecil CreateField(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            return new StaticClassFieldWithMonoCecil(declaringType, field);
        }

        protected override IIndexer CreateIndexer(ITypeWithMonoCecil declaringType, PropertyDefinition indexer)
        {
            throw new NotSupportedException();
        }

        protected override StaticClassMethodWithMonoCecil CreateMethod(ITypeWithMonoCecil declaringType, MethodDefinition method)
        {
            return new StaticClassMethodWithMonoCecil(declaringType, method);
        }

        protected override StaticClassNestedAbstractClassWithMonoCecil CreateNestedAbstractClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedAbstractClassWithMonoCecil(declaringType, type);
        }

        protected override StaticClassNestedClassWithMonoCecil CreateNestedClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedClassWithMonoCecil(declaringType, type);
        }

        protected override StaticClassNestedDelegateWithMonoCecil CreateNestedDelegate(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedDelegateWithMonoCecil(declaringType, type);
        }

        protected override StaticClassNestedEnumWithMonoCecil CreateNestedEnum(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedEnumWithMonoCecil(declaringType, type);
        }

        protected override StaticClassNestedInterfaceWithMonoCecil CreateNestedInterface(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedInterfaceWithMonoCecil(declaringType, type);
        }

        protected override StaticClassNestedSealedClassWithMonoCecil CreateNestedSealedClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedSealedClassWithMonoCecil(declaringType, type);
        }

        protected override StaticClassNestedStaticClassWithMonoCecil CreateNestedStaticClass(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedStaticClassWithMonoCecil(declaringType, type);
        }

        protected override StaticClassNestedStructWithMonoCecil CreateNestedStruct(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            return new StaticClassNestedStructWithMonoCecil(declaringType, type);
        }

        protected override StaticClassPropertyWithMonoCecil CreateProperty(ITypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            return new StaticClassPropertyWithMonoCecil(declaringType, property);
        }
    }
}
