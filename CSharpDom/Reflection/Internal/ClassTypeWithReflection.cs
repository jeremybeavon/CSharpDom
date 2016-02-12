using System;
using System.Reflection;
using CSharpDom.Common;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ClassTypeWithReflection :
        TypeWithReflection<
            IInternalTypeWithReflection,
            ClassEventWithReflection,
            ClassPropertyWithReflection,
            ClassIndexerWithReflection,
            ClassMethodWithReflection,
            ClassFieldWithReflection,
            ClassConstructorWithReflection,
            ClassEventPropertyWithReflection,
            ClassNestedClassWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceWithReflection,
            ClassNestedStructWithReflection>,
        IInternalClassTypeWithReflection
    {
        private readonly ClassNestedClassCollectionWithReflection classes;
        private readonly ClassEventCollectionWithReflection events;
        private readonly ClassFieldCollectionWithReflection fields;
        private readonly ClassIndexerCollectionWithReflection indexers;
        private readonly ClassNestedInterfaceCollectionWithReflection interfaces;
        private readonly ClassMethodCollectionWithReflection methods;
        private readonly ClassPropertyCollectionWithReflection properties;
        private readonly ClassNestedStructCollectionWithReflection structs;

        public ClassTypeWithReflection(IInternalTypeWithReflection declaringType)
            : base(declaringType)
        {
            classes = new ClassNestedClassCollectionWithReflection(this);
            events = new ClassEventCollectionWithReflection(this);
            fields = new ClassFieldCollectionWithReflection(this);
            indexers = new ClassIndexerCollectionWithReflection(this);
            interfaces = new ClassNestedInterfaceCollectionWithReflection(this);
            methods = new ClassMethodCollectionWithReflection(this);
            properties = new ClassPropertyCollectionWithReflection(this);
            structs = new ClassNestedStructCollectionWithReflection(this);
        }

        ClassNestedClassCollectionWithReflection IHasClassCollection<ClassNestedClassCollectionWithReflection>.Classes
        {
            get { return classes; }
        }

        ClassEventCollectionWithReflection IHasEventCollection<ClassEventCollectionWithReflection>.Events
        {
            get { return events; }
        }

        ClassFieldCollectionWithReflection IHasFieldCollection<ClassFieldCollectionWithReflection>.Fields
        {
            get { return fields; }
        }

        ClassIndexerCollectionWithReflection IHasIndexerCollection<ClassIndexerCollectionWithReflection>.Indexers
        {
            get { return indexers; }
        }

        ClassNestedInterfaceCollectionWithReflection IHasInterfaceCollection<ClassNestedInterfaceCollectionWithReflection>.Interfaces
        {
            get { return interfaces; }
        }

        ClassMethodCollectionWithReflection IHasMethodCollection<ClassMethodCollectionWithReflection>.Methods
        {
            get { return methods; }
        }

        ClassPropertyCollectionWithReflection IHasPropertyCollection<ClassPropertyCollectionWithReflection>.Properties
        {
            get { return properties; }
        }

        ClassNestedStructCollectionWithReflection IHasStructCollection<ClassNestedStructCollectionWithReflection>.Structs
        {
            get { return structs; }
        }

        protected override ClassConstructorWithReflection CreateConstructor(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            return new ClassConstructorWithReflection(declaringType, constructor);
        }

        protected override ClassEventWithReflection CreateEvent(IInternalTypeWithReflection declaringType, EventInfo @event)
        {
            return new ClassEventWithReflection(declaringType, @event);
        }

        protected override ClassEventPropertyWithReflection CreateEventProperty(
            IInternalTypeWithReflection declaringType,
            EventInfo @event)
        {
            return new ClassEventPropertyWithReflection(declaringType, @event);
        }

        protected override ClassFieldWithReflection CreateField(IInternalTypeWithReflection declaringType, FieldInfo field)
        {
            return new ClassFieldWithReflection(declaringType, field);
        }

        protected override ClassIndexerWithReflection CreateIndexer(IInternalTypeWithReflection declaringType, PropertyInfo indexer)
        {
            return new ClassIndexerWithReflection(declaringType, indexer);
        }

        protected override ClassMethodWithReflection CreateMethod(IInternalTypeWithReflection declaringType, MethodInfo method)
        {
            return new ClassMethodWithReflection(declaringType, method);
        }

        protected override ClassNestedClassWithReflection CreateNestedClass(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedClassWithReflection(declaringType, type);
        }

        protected override ClassNestedDelegateWithReflection CreateNestedDelegate(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedDelegateWithReflection(declaringType, type);
        }

        protected override ClassNestedEnumWithReflection CreateNestedEnum(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedEnumWithReflection(declaringType, type);
        }

        protected override ClassNestedInterfaceWithReflection CreateNestedInterface(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedInterfaceWithReflection(declaringType, type);
        }

        protected override ClassNestedStructWithReflection CreateNestedStruct(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedStructWithReflection(declaringType, type);
        }

        protected override ClassPropertyWithReflection CreateProperty(IInternalTypeWithReflection declaringType, PropertyInfo property)
        {
            return new ClassPropertyWithReflection(declaringType, property);
        }
    }
}
