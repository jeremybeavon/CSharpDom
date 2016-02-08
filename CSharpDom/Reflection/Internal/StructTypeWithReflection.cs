using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class StructTypeWithReflection :
        TypeWithReflection<
            ITypeWithReflection,
            StructEventWithReflection,
            StructPropertyWithReflection,
            StructIndexerWithReflection,
            StructMethodWithReflection,
            StructFieldWithReflection,
            StructConstructorWithReflection,
            StructEventPropertyWithReflection,
            StructNestedClassWithReflection,
            StructNestedDelegateWithReflection,
            StructNestedEnumWithReflection,
            StructNestedInterfaceWithReflection,
            StructNestedStructWithReflection>
    {
        public StructTypeWithReflection(ITypeWithReflection declaringType, Type type)
            : base(declaringType, type)
        {
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
