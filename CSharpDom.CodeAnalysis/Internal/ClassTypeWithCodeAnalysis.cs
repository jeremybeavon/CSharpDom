using System;
using System.Reflection;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class ClassTypeWithCodeAnalysis :
        TypeWithCodeAnalysis<
            IInternalTypeWithCodeAnalysis,
            ClassEventCollectionWithCodeAnalysis,
            ClassEventWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            ClassPropertyCollectionWithCodeAnalysis,
            ClassPropertyWithCodeAnalysis,
            ClassIndexerCollectionWithCodeAnalysis,
            ClassIndexerWithCodeAnalysis,
            ClassMethodCollectionWithCodeAnalysis,
            ClassMethodWithCodeAnalysis,
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
        private readonly ClassEventCollectionWithCodeAnalysis events;
        private readonly ClassFieldCollectionWithCodeAnalysis fields;
        private readonly ClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly ClassNestedInterfaceCollectionWithCodeAnalysis interfaces;
        private readonly ClassMethodCollectionWithCodeAnalysis methods;
        private readonly ClassPropertyCollectionWithCodeAnalysis properties;
        private readonly ClassNestedStructCollectionWithCodeAnalysis structs;

        public ClassTypeWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType)
            : base(declaringType)
        {
            classes = new ClassNestedClassCollectionWithCodeAnalysis(this);
            events = new ClassEventCollectionWithCodeAnalysis(this);
            fields = new ClassFieldCollectionWithCodeAnalysis(this);
            indexers = new ClassIndexerCollectionWithCodeAnalysis(this);
            interfaces = new ClassNestedInterfaceCollectionWithCodeAnalysis(this);
            methods = new ClassMethodCollectionWithCodeAnalysis(this);
            properties = new ClassPropertyCollectionWithCodeAnalysis(this);
            structs = new ClassNestedStructCollectionWithCodeAnalysis(this);
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
        }

        public override ClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
        }

        public override ClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return interfaces; }
        }

        public override ClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
        }

        public override ClassPropertyCollectionWithCodeAnalysis Properties
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

        protected override ClassEventWithCodeAnalysis CreateEvent(IInternalTypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            return new ClassEventWithCodeAnalysis(declaringType, @event);
        }

        protected override ClassEventPropertyWithCodeAnalysis CreateEventProperty(
            IInternalTypeWithCodeAnalysis declaringType,
            EventDefinition @event)
        {
            return new ClassEventPropertyWithCodeAnalysis(declaringType, @event);
        }

        protected override ClassFieldWithCodeAnalysis CreateField(IInternalTypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            return new ClassFieldWithCodeAnalysis(declaringType, field);
        }

        protected override ClassIndexerWithCodeAnalysis CreateIndexer(IInternalTypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            return new ClassIndexerWithCodeAnalysis(declaringType, indexer);
        }

        protected override ClassMethodWithCodeAnalysis CreateMethod(IInternalTypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            return new ClassMethodWithCodeAnalysis(declaringType, method);
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

        protected override ClassPropertyWithCodeAnalysis CreateProperty(IInternalTypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            return new ClassPropertyWithCodeAnalysis(declaringType, property);
        }
    }
}
