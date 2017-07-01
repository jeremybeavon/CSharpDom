using System;
using System.Reflection;
using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ClassTypeWithReflection :
        TypeWithReflection<
            IInternalTypeWithReflection,
            ClassEventCollectionWithReflection,
            ClassEventWithReflection,
            ClassEventPropertyWithReflection,
            ClassPropertyCollectionWithReflection,
            ClassPropertyWithReflection,
            ClassIndexerCollectionWithReflection,
            ClassIndexerWithReflection,
            ClassMethodCollectionWithReflection,
            ClassMethodWithReflection,
            ClassFieldCollectionWithReflection,
            ClassFieldWithReflection,
            ClassConstantWithReflection,
            ClassConstructorWithReflection,
            ClassNestedClassCollectionWithReflection,
            ClassNestedAbstractClassWithReflection,
            ClassNestedClassWithReflection,
            ClassNestedSealedClassWithReflection,
            ClassNestedStaticClassWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceWithReflection,
            ClassNestedStructCollectionWithReflection,
            ClassNestedStructWithReflection>
    {
        private readonly ClassNestedClassCollectionWithReflection classes;
        private readonly ClassEventCollectionWithReflection events;
        private readonly ClassFieldCollectionWithReflection fields;
        private readonly ClassIndexerCollectionWithReflection indexers;
        private readonly IReadOnlyCollection<ClassNestedInterfaceWithReflection> interfaces;
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
            interfaces = new ReadOnlyCollection<ClassNestedInterfaceWithReflection>(null);
            methods = new ClassMethodCollectionWithReflection(this);
            properties = new ClassPropertyCollectionWithReflection(this);
            structs = new ClassNestedStructCollectionWithReflection(this);
        }

        public override ClassNestedClassCollectionWithReflection Classes
        {
            get { return classes; }
        }

        public override ClassEventCollectionWithReflection Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithReflection Fields
        {
            get { return fields; }
        }

        public override ClassIndexerCollectionWithReflection Indexers
        {
            get { return indexers; }
        }

        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return interfaces; }
        }

        public override ClassMethodCollectionWithReflection Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassPropertyCollectionWithReflection Properties
        {
            get { return properties; }
        }

        public override ClassNestedStructCollectionWithReflection Structs
        {
            get { return structs; }
        }

        protected override ClassConstantWithReflection CreateConstant(IInternalTypeWithReflection declaringType, FieldInfo field)
        {
            return new ClassConstantWithReflection(declaringType, field);
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

        protected override ClassNestedAbstractClassWithReflection CreateNestedAbstractClass(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedAbstractClassWithReflection(declaringType, type);
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

        protected override ClassNestedSealedClassWithReflection CreateNestedSealedClass(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedSealedClassWithReflection((IInternalTypeWithReflection)declaringType, type);
        }

        protected override ClassNestedStaticClassWithReflection CreateNestedStaticClass(ITypeWithReflection declaringType, Type type)
        {
            return new ClassNestedStaticClassWithReflection(declaringType, type);
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
