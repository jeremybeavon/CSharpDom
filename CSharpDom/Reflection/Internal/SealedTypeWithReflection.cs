﻿using System;
using System.Reflection;
using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class SealedTypeWithReflection :
        TypeWithReflection<
            IInternalTypeWithReflection,
            SealedClassEventCollectionWithReflection,
            SealedClassEventWithReflection,
            SealedClassEventPropertyWithReflection,
            SealedClassPropertyCollectionWithReflection,
            SealedClassPropertyWithReflection,
            SealedClassIndexerCollectionWithReflection,
            SealedClassIndexerWithReflection,
            SealedClassMethodCollectionWithReflection,
            SealedClassMethodWithReflection,
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
        private readonly SealedClassEventCollectionWithReflection events;
        private readonly ClassFieldCollectionWithReflection fields;
        private readonly SealedClassIndexerCollectionWithReflection indexers;
        private readonly SealedClassMethodCollectionWithReflection methods;
        private readonly SealedClassPropertyCollectionWithReflection properties;
        private readonly ClassNestedStructCollectionWithReflection structs;

        public SealedTypeWithReflection(IInternalTypeWithReflection declaringType)
            : base(declaringType)
        {
            classes = new ClassNestedClassCollectionWithReflection(this);
            events = new SealedClassEventCollectionWithReflection(this);
            fields = new ClassFieldCollectionWithReflection(this);
            indexers = new SealedClassIndexerCollectionWithReflection(this);
            methods = new SealedClassMethodCollectionWithReflection(this);
            properties = new SealedClassPropertyCollectionWithReflection(this);
            structs = new ClassNestedStructCollectionWithReflection(this);
        }

        public override ClassNestedClassCollectionWithReflection Classes
        {
            get { return classes; }
        }

        public override SealedClassEventCollectionWithReflection Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithReflection Fields
        {
            get { return fields; }
        }

        public override SealedClassIndexerCollectionWithReflection Indexers
        {
            get { return indexers; }
        }
        
        public override SealedClassMethodCollectionWithReflection Methods
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

        public override SealedClassPropertyCollectionWithReflection Properties
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

        protected override SealedClassEventWithReflection CreateEvent(IInternalTypeWithReflection declaringType, EventInfo @event)
        {
            return new SealedClassEventWithReflection(declaringType, @event);
        }

        protected override SealedClassEventPropertyWithReflection CreateEventProperty(
            IInternalTypeWithReflection declaringType,
            EventInfo @event)
        {
            return new SealedClassEventPropertyWithReflection(declaringType, @event);
        }

        protected override ClassFieldWithReflection CreateField(IInternalTypeWithReflection declaringType, FieldInfo field)
        {
            return new ClassFieldWithReflection(declaringType, field);
        }

        protected override SealedClassIndexerWithReflection CreateIndexer(IInternalTypeWithReflection declaringType, PropertyInfo indexer)
        {
            return new SealedClassIndexerWithReflection(declaringType, indexer);
        }

        protected override SealedClassMethodWithReflection CreateMethod(IInternalTypeWithReflection declaringType, MethodInfo method)
        {
            return new SealedClassMethodWithReflection(declaringType, method);
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

        protected override SealedClassPropertyWithReflection CreateProperty(IInternalTypeWithReflection declaringType, PropertyInfo property)
        {
            return new SealedClassPropertyWithReflection(declaringType, property);
        }
    }
}
