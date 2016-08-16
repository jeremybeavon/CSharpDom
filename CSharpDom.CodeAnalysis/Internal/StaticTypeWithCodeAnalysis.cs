using System;
using System.Reflection;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class StaticTypeWithCodeAnalysis :
        TypeWithCodeAnalysis<
            ITypeWithCodeAnalysis,
            StaticClassEventCollectionWithCodeAnalysis,
            StaticClassEventWithCodeAnalysis,
            StaticClassEventPropertyWithCodeAnalysis,
            StaticClassPropertyCollectionWithCodeAnalysis,
            StaticClassPropertyWithCodeAnalysis,
            IIndexerCollection,
            IIndexer,
            StaticClassMethodCollectionWithCodeAnalysis,
            StaticClassMethodWithCodeAnalysis,
            StaticClassFieldCollectionWithCodeAnalysis,
            StaticClassFieldWithCodeAnalysis,
            StaticClassConstantWithCodeAnalysis,
            IConstructor,
            StaticClassNestedClassCollectionWithCodeAnalysis,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            StaticClassNestedClassWithCodeAnalysis,
            StaticClassNestedSealedClassWithCodeAnalysis,
            StaticClassNestedStaticClassWithCodeAnalysis,
            StaticClassNestedDelegateWithCodeAnalysis,
            StaticClassNestedEnumWithCodeAnalysis,
            StaticClassNestedInterfaceCollectionWithCodeAnalysis,
            StaticClassNestedInterfaceWithCodeAnalysis,
            StaticClassNestedStructCollectionWithCodeAnalysis,
            StaticClassNestedStructWithCodeAnalysis>
    {
        private readonly StaticClassNestedClassCollectionWithCodeAnalysis classes;
        private readonly StaticClassEventCollectionWithCodeAnalysis events;
        private readonly StaticClassFieldCollectionWithCodeAnalysis fields;
        private readonly StaticClassNestedInterfaceCollectionWithCodeAnalysis interfaces;
        private readonly StaticClassMethodCollectionWithCodeAnalysis methods;
        private readonly StaticClassPropertyCollectionWithCodeAnalysis properties;
        private readonly StaticClassNestedStructCollectionWithCodeAnalysis structs;

        public StaticTypeWithCodeAnalysis(ITypeWithCodeAnalysis declaringType)
            : base(declaringType)
        {
            classes = new StaticClassNestedClassCollectionWithCodeAnalysis(this);
            events = new StaticClassEventCollectionWithCodeAnalysis(this);
            fields = new StaticClassFieldCollectionWithCodeAnalysis(this);
            interfaces = new StaticClassNestedInterfaceCollectionWithCodeAnalysis(this);
            methods = new StaticClassMethodCollectionWithCodeAnalysis(this);
            properties = new StaticClassPropertyCollectionWithCodeAnalysis(this);
            structs = new StaticClassNestedStructCollectionWithCodeAnalysis(this);
        }

        public override StaticClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
        }

        public override StaticClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
        }

        public override StaticClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return fields; }
        }

        public override IIndexerCollection Indexers
        {
            get { throw new NotSupportedException(); }
        }

        public override StaticClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return interfaces; }
        }

        public override StaticClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
        }

        public override StaticClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
        }

        public override StaticClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
        }

        protected override StaticClassConstantWithCodeAnalysis CreateConstant(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            return new StaticClassConstantWithCodeAnalysis(declaringType, field);
        }

        protected override IConstructor CreateConstructor(ITypeWithCodeAnalysis declaringType, MethodDefinition constructor)
        {
            throw new NotSupportedException();
        }

        protected override StaticClassEventWithCodeAnalysis CreateEvent(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            return new StaticClassEventWithCodeAnalysis(declaringType, @event);
        }

        protected override StaticClassEventPropertyWithCodeAnalysis CreateEventProperty(
            ITypeWithCodeAnalysis declaringType,
            EventDefinition @event)
        {
            return new StaticClassEventPropertyWithCodeAnalysis(declaringType, @event);
        }

        protected override StaticClassFieldWithCodeAnalysis CreateField(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            return new StaticClassFieldWithCodeAnalysis(declaringType, field);
        }

        protected override IIndexer CreateIndexer(ITypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            throw new NotSupportedException();
        }

        protected override StaticClassMethodWithCodeAnalysis CreateMethod(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            return new StaticClassMethodWithCodeAnalysis(declaringType, method);
        }

        protected override StaticClassNestedAbstractClassWithCodeAnalysis CreateNestedAbstractClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedAbstractClassWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassNestedClassWithCodeAnalysis CreateNestedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedClassWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassNestedDelegateWithCodeAnalysis CreateNestedDelegate(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedDelegateWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassNestedEnumWithCodeAnalysis CreateNestedEnum(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedEnumWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassNestedInterfaceWithCodeAnalysis CreateNestedInterface(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedInterfaceWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassNestedSealedClassWithCodeAnalysis CreateNestedSealedClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedSealedClassWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassNestedStaticClassWithCodeAnalysis CreateNestedStaticClass(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedStaticClassWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassNestedStructWithCodeAnalysis CreateNestedStruct(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            return new StaticClassNestedStructWithCodeAnalysis(declaringType, type);
        }

        protected override StaticClassPropertyWithCodeAnalysis CreateProperty(ITypeWithCodeAnalysis declaringType, PropertyDefinition property)
        {
            return new StaticClassPropertyWithCodeAnalysis(declaringType, property);
        }
    }
}
