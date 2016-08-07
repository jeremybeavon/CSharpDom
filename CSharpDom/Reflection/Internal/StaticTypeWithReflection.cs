using System;
using System.Reflection;
using CSharpDom.Common;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class StaticTypeWithReflection :
        TypeWithReflection<
            ITypeWithReflection,
            StaticClassEventCollectionWithReflection,
            StaticClassEventWithReflection,
            StaticClassEventPropertyWithReflection,
            StaticClassPropertyCollectionWithReflection,
            StaticClassPropertyWithReflection,
            IIndexerCollection,
            IIndexer,
            StaticClassMethodCollectionWithReflection,
            StaticClassMethodWithReflection,
            StaticClassFieldCollectionWithReflection,
            StaticClassFieldWithReflection,
            StaticClassConstantWithReflection,
            IConstructor,
            StaticClassNestedClassCollectionWithReflection,
            StaticClassNestedAbstractClassWithReflection,
            StaticClassNestedClassWithReflection,
            StaticClassNestedSealedClassWithReflection,
            StaticClassNestedStaticClassWithReflection,
            StaticClassNestedDelegateWithReflection,
            StaticClassNestedEnumWithReflection,
            StaticClassNestedInterfaceCollectionWithReflection,
            StaticClassNestedInterfaceWithReflection,
            StaticClassNestedStructCollectionWithReflection,
            StaticClassNestedStructWithReflection>
    {
        private readonly StaticClassNestedClassCollectionWithReflection classes;
        private readonly StaticClassEventCollectionWithReflection events;
        private readonly StaticClassFieldCollectionWithReflection fields;
        private readonly StaticClassNestedInterfaceCollectionWithReflection interfaces;
        private readonly StaticClassMethodCollectionWithReflection methods;
        private readonly StaticClassPropertyCollectionWithReflection properties;
        private readonly StaticClassNestedStructCollectionWithReflection structs;

        public StaticTypeWithReflection(ITypeWithReflection declaringType)
            : base(declaringType)
        {
            classes = new StaticClassNestedClassCollectionWithReflection(this);
            events = new StaticClassEventCollectionWithReflection(this);
            fields = new StaticClassFieldCollectionWithReflection(this);
            interfaces = new StaticClassNestedInterfaceCollectionWithReflection(this);
            methods = new StaticClassMethodCollectionWithReflection(this);
            properties = new StaticClassPropertyCollectionWithReflection(this);
            structs = new StaticClassNestedStructCollectionWithReflection(this);
        }

        public override StaticClassNestedClassCollectionWithReflection Classes
        {
            get { return classes; }
        }

        public override StaticClassEventCollectionWithReflection Events
        {
            get { return events; }
        }

        public override StaticClassFieldCollectionWithReflection Fields
        {
            get { return fields; }
        }

        public override IIndexerCollection Indexers
        {
            get { throw new NotSupportedException(); }
        }

        public override StaticClassNestedInterfaceCollectionWithReflection Interfaces
        {
            get { return interfaces; }
        }

        public override StaticClassMethodCollectionWithReflection Methods
        {
            get { return methods; }
        }

        public override StaticClassPropertyCollectionWithReflection Properties
        {
            get { return properties; }
        }

        public override StaticClassNestedStructCollectionWithReflection Structs
        {
            get { return structs; }
        }

        protected override StaticClassConstantWithReflection CreateConstant(ITypeWithReflection declaringType, FieldInfo field)
        {
            return new StaticClassConstantWithReflection(declaringType, field);
        }

        protected override IConstructor CreateConstructor(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            throw new NotSupportedException();
        }

        protected override StaticClassEventWithReflection CreateEvent(ITypeWithReflection declaringType, EventInfo @event)
        {
            return new StaticClassEventWithReflection(declaringType, @event);
        }

        protected override StaticClassEventPropertyWithReflection CreateEventProperty(
            ITypeWithReflection declaringType,
            EventInfo @event)
        {
            return new StaticClassEventPropertyWithReflection(declaringType, @event);
        }

        protected override StaticClassFieldWithReflection CreateField(ITypeWithReflection declaringType, FieldInfo field)
        {
            return new StaticClassFieldWithReflection(declaringType, field);
        }

        protected override IIndexer CreateIndexer(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            throw new NotSupportedException();
        }

        protected override StaticClassMethodWithReflection CreateMethod(ITypeWithReflection declaringType, MethodInfo method)
        {
            return new StaticClassMethodWithReflection(declaringType, method);
        }

        protected override StaticClassNestedAbstractClassWithReflection CreateNestedAbstractClass(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedAbstractClassWithReflection(declaringType, type);
        }

        protected override StaticClassNestedClassWithReflection CreateNestedClass(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedClassWithReflection(declaringType, type);
        }

        protected override StaticClassNestedDelegateWithReflection CreateNestedDelegate(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedDelegateWithReflection(declaringType, type);
        }

        protected override StaticClassNestedEnumWithReflection CreateNestedEnum(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedEnumWithReflection(declaringType, type);
        }

        protected override StaticClassNestedInterfaceWithReflection CreateNestedInterface(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedInterfaceWithReflection(declaringType, type);
        }

        protected override StaticClassNestedSealedClassWithReflection CreateNestedSealedClass(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedSealedClassWithReflection((IInternalTypeWithReflection)declaringType, type);
        }

        protected override StaticClassNestedStaticClassWithReflection CreateNestedStaticClass(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedStaticClassWithReflection(declaringType, type);
        }

        protected override StaticClassNestedStructWithReflection CreateNestedStruct(ITypeWithReflection declaringType, Type type)
        {
            return new StaticClassNestedStructWithReflection(declaringType, type);
        }

        protected override StaticClassPropertyWithReflection CreateProperty(ITypeWithReflection declaringType, PropertyInfo property)
        {
            return new StaticClassPropertyWithReflection(declaringType, property);
        }
    }
}
