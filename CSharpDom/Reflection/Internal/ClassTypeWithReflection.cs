using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ClassTypeWithReflection :
        TypeWithReflection<
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
            ClassNestedStructWithReflection>
    {
        public ClassTypeWithReflection(ITypeWithReflection declaringType, Type type)
            : base(declaringType, type)
        {
        }

        protected override ClassConstructorWithReflection CreateConstructor(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            return new ClassConstructorWithReflection(declaringType, constructor);
        }

        protected override ClassEventWithReflection CreateEvent(ITypeWithReflection declaringType, EventInfo @event)
        {
            return new ClassEventWithReflection(declaringType, @event);
        }

        protected override ClassEventPropertyWithReflection CreateEventProperty(ITypeWithReflection declaringType, EventInfo @event)
        {
            return new ClassEventPropertyWithReflection(declaringType, @event);
        }

        protected override ClassFieldWithReflection CreateField(ITypeWithReflection declaringType, FieldInfo field)
        {
            return new ClassFieldWithReflection(declaringType, field);
        }

        protected override ClassIndexerWithReflection CreateIndexer(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            return new ClassIndexerWithReflection(declaringType, indexer);
        }

        protected override ClassMethodWithReflection CreateMethod(ITypeWithReflection declaringType, MethodInfo method)
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

        protected override ClassPropertyWithReflection CreateProperty(ITypeWithReflection declaringType, PropertyInfo property)
        {
            return new ClassPropertyWithReflection(declaringType, property);
        }
    }
}
