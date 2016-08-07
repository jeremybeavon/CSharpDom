using CSharpDom.Common;
using System;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class StructTypeWithReflection :
        TypeWithReflection<
            ITypeWithReflection,
            StructEventCollectionWithReflection,
            StructEventWithReflection,
            StructEventPropertyWithReflection,
            StructPropertyCollectionWithReflection,
            StructPropertyWithReflection,
            StructIndexerCollectionWithReflection,
            StructIndexerWithReflection,
            StructMethodCollectionWithReflection,
            StructMethodWithReflection,
            StructFieldCollectionWithReflection,
            StructFieldWithReflection,
            StructConstructorWithReflection,
            StructNestedClassCollectionWithReflection,
            StructNestedAbstractClassWithReflection,
            StructNestedClassWithReflection,
            StructNestedSealedClassWithReflection,
            StructNestedStaticClassWithReflection,
            StructNestedDelegateWithReflection,
            StructNestedEnumWithReflection,
            StructNestedInterfaceCollectionWithReflection,
            StructNestedInterfaceWithReflection,
            StructNestedStructCollectionWithReflection,
            StructNestedStructWithReflection>
    {
        private readonly StructNestedClassCollectionWithReflection classes;
        private readonly StructEventCollectionWithReflection events;
        private readonly StructFieldCollectionWithReflection fields;
        private readonly StructIndexerCollectionWithReflection indexers;
        private readonly StructNestedInterfaceCollectionWithReflection interfaces;
        private readonly StructMethodCollectionWithReflection methods;
        private readonly StructPropertyCollectionWithReflection properties;
        private readonly StructNestedStructCollectionWithReflection structs;

        public StructTypeWithReflection(ITypeWithReflection declaringType)
            : base(declaringType)
        {
            classes = new StructNestedClassCollectionWithReflection(this);
            events = new StructEventCollectionWithReflection(this);
            fields = new StructFieldCollectionWithReflection(this);
            indexers = new StructIndexerCollectionWithReflection(this);
            interfaces = new StructNestedInterfaceCollectionWithReflection(this);
            methods = new StructMethodCollectionWithReflection(this);
            properties = new StructPropertyCollectionWithReflection(this);
            structs = new StructNestedStructCollectionWithReflection(this);
        }

        public override StructNestedClassCollectionWithReflection Classes
        {
            get { return classes; }
        }

        public override StructEventCollectionWithReflection Events
        {
            get { return events; }
        }

        public override StructFieldCollectionWithReflection Fields
        {
            get { return fields; }
        }

        public override StructIndexerCollectionWithReflection Indexers
        {
            get { return indexers; }
        }

        public override StructNestedInterfaceCollectionWithReflection Interfaces
        {
            get { return interfaces; }
        }

        public override StructMethodCollectionWithReflection Methods
        {
            get { return methods; }
        }

        public override StructPropertyCollectionWithReflection Properties
        {
            get { return properties; }
        }

        public override StructNestedStructCollectionWithReflection Structs
        {
            get { return structs; }
        }

        protected override StructConstructorWithReflection CreateConstructor(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            return new StructConstructorWithReflection(declaringType, constructor);
        }

        protected override StructEventWithReflection CreateEvent(ITypeWithReflection declaringType, EventInfo @event)
        {
            return new StructEventWithReflection(declaringType, @event);
        }

        protected override StructEventPropertyWithReflection CreateEventProperty(ITypeWithReflection declaringType, EventInfo @event)
        {
            return new StructEventPropertyWithReflection(declaringType, @event);
        }

        protected override StructFieldWithReflection CreateField(ITypeWithReflection declaringType, FieldInfo field)
        {
            return new StructFieldWithReflection(declaringType, field);
        }

        protected override StructIndexerWithReflection CreateIndexer(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            return new StructIndexerWithReflection(declaringType, indexer);
        }

        protected override StructMethodWithReflection CreateMethod(ITypeWithReflection declaringType, MethodInfo method)
        {
            return new StructMethodWithReflection(declaringType, method);
        }

        protected override StructNestedAbstractClassWithReflection CreateNestedAbstractClass(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedAbstractClassWithReflection(declaringType, type);
        }

        protected override StructNestedClassWithReflection CreateNestedClass(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedClassWithReflection(declaringType, type);
        }

        protected override StructNestedDelegateWithReflection CreateNestedDelegate(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedDelegateWithReflection(declaringType, type);
        }

        protected override StructNestedEnumWithReflection CreateNestedEnum(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedEnumWithReflection(declaringType, type);
        }

        protected override StructNestedInterfaceWithReflection CreateNestedInterface(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedInterfaceWithReflection(declaringType, type);
        }

        protected override StructNestedSealedClassWithReflection CreateNestedSealedClass(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedSealedClassWithReflection(declaringType, type);
        }

        protected override StructNestedStaticClassWithReflection CreateNestedStaticClass(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedStaticClassWithReflection(declaringType, type);
        }

        protected override StructNestedStructWithReflection CreateNestedStruct(ITypeWithReflection declaringType, Type type)
        {
            return new StructNestedStructWithReflection(declaringType, type);
        }

        protected override StructPropertyWithReflection CreateProperty(ITypeWithReflection declaringType, PropertyInfo property)
        {
            return new StructPropertyWithReflection(declaringType, property);
        }
    }
}
