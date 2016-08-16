using System;
using System.Reflection;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class SealedTypeWithCodeAnalysis :
        TypeWithCodeAnalysis<
            IInternalTypeWithCodeAnalysis,
            SealedClassEventCollectionWithCodeAnalysis,
            SealedClassEventWithCodeAnalysis,
            SealedClassEventPropertyWithCodeAnalysis,
            SealedClassPropertyCollectionWithCodeAnalysis,
            SealedClassPropertyWithCodeAnalysis,
            SealedClassIndexerCollectionWithCodeAnalysis,
            SealedClassIndexerWithCodeAnalysis,
            SealedClassMethodCollectionWithCodeAnalysis,
            SealedClassMethodWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassFieldWithCodeAnalysis,
            ClassConstantWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedAbstractClassWithCodeAnalysis,
            ClassNestedClassWithCodeAnalysis,
            ClassNestedSealedClassWithCodeAnalysis,
            ClassNestedStaticClassWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedInterfaceWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            ClassNestedStructWithCodeAnalysis>
    {
        private readonly ClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly SealedClassEventCollectionWithCodeAnalysis events;
        private readonly ClassFieldCollectionWithCodeAnalysis fields;
        private readonly SealedClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly ClassNestedInterfaceCollectionWithCodeAnalysis interfaces;
        private readonly SealedClassMethodCollectionWithCodeAnalysis methods;
        private readonly SealedClassPropertyCollectionWithCodeAnalysis properties;
        private readonly ClassNestedStructCollectionWithCodeAnalysis structs;

        public SealedTypeWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType)
            : base(declaringType)
        {
            classes = new ClassNestedClassCollectionWithCodeAnalysis(this);
            events = new SealedClassEventCollectionWithCodeAnalysis(this);
            fields = new ClassFieldCollectionWithCodeAnalysis(this);
            indexers = new SealedClassIndexerCollectionWithCodeAnalysis(this);
            interfaces = new ClassNestedInterfaceCollectionWithCodeAnalysis(this);
            methods = new SealedClassMethodCollectionWithCodeAnalysis(this);
            properties = new SealedClassPropertyCollectionWithCodeAnalysis(this);
            structs = new ClassNestedStructCollectionWithCodeAnalysis(this);
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
        }

        public override SealedClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
        }

        public override SealedClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return interfaces; }
        }

        public override SealedClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
        }

        public override SealedClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
        }

        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
        }

        protected override ClassConstantWithCodeAnalysis CreateConstant(IInternalTypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            return new ClassConstantWithCodeAnalysis(declaringType, field);
        }

        protected override ClassConstructorWithCodeAnalysis CreateConstructor(IInternalTypeWithCodeAnalysis declaringType, MethodDefinition constructor)
        {
            return new ClassConstructorWithCodeAnalysis(declaringType, constructor);
        }

        protected override SealedClassEventWithCodeAnalysis CreateEvent(IInternalTypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            return new SealedClassEventWithCodeAnalysis(declaringType, @event);
        }

        protected override SealedClassEventPropertyWithCodeAnalysis CreateEventProperty(
            IInternalTypeWithCodeAnalysis declaringType,
            EventDefinition @event)
        {
            return new SealedClassEventPropertyWithCodeAnalysis(declaringType, @event);
        }

        protected override ClassFieldWithCodeAnalysis CreateField(IInternalTypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            return new ClassFieldWithCodeAnalysis(declaringType, field);
        }

        protected override SealedClassIndexerWithCodeAnalysis CreateIndexer(IInternalTypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            return new SealedClassIndexerWithCodeAnalysis(declaringType, indexer);
        }

        protected override SealedClassMethodWithCodeAnalysis CreateMethod(IInternalTypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            return new SealedClassMethodWithCodeAnalysis(declaringType, method);
        }

        protected override ClassNestedAbstractClassWithCodeAnalysis CreateNestedAbstractClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedAbstractClassWithCodeAnalysis(declaringType, type);
        }

        protected override ClassNestedClassWithCodeAnalysis CreateNestedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedClassWithCodeAnalysis(declaringType, type);
        }

        protected override ClassNestedDelegateWithCodeAnalysis CreateNestedDelegate(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedDelegateWithCodeAnalysis(declaringType, type);
        }

        protected override ClassNestedEnumWithCodeAnalysis CreateNestedEnum(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedEnumWithCodeAnalysis(declaringType, type);
        }

        protected override ClassNestedInterfaceWithCodeAnalysis CreateNestedInterface(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedInterfaceWithCodeAnalysis(declaringType, type);
        }

        protected override ClassNestedSealedClassWithCodeAnalysis CreateNestedSealedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedSealedClassWithCodeAnalysis(declaringType, type);
        }

        protected override ClassNestedStaticClassWithCodeAnalysis CreateNestedStaticClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedStaticClassWithCodeAnalysis(declaringType, type);
        }

        protected override ClassNestedStructWithCodeAnalysis CreateNestedStruct(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new ClassNestedStructWithCodeAnalysis(declaringType, type);
        }

        protected override SealedClassPropertyWithCodeAnalysis CreateProperty(IInternalTypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            return new SealedClassPropertyWithCodeAnalysis(declaringType, property);
        }
    }
}
