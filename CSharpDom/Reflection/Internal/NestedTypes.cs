using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedTypes<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>
    {
        public NestedTypes(
            ITypeWithReflection declaringType,
            Type type,
            INestedTypeFactory<TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> factory)
        {
            List<TNestedClass> nestedClasses = new List<TNestedClass>();
            List<TNestedDelegate> nestedDelegates = new List<TNestedDelegate>();
            List<TNestedEnum> nestedEnums = new List<TNestedEnum>();
            List<TNestedInterface> nestedInterfaces = new List<TNestedInterface>();
            List<TNestedStruct> nestedStructs = new List<TNestedStruct>();
            foreach (Type nestedType in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
            {
                switch (nestedType.TypeClassification())
                {
                    case TypeClassification.Class:
                        nestedClasses.Add(factory.CreateNestedClass(declaringType, nestedType));
                        break;
                    case TypeClassification.Delegate:
                        nestedDelegates.Add(factory.CreateNestedDelegate(declaringType, nestedType));
                        break;
                    case TypeClassification.Enum:
                        nestedEnums.Add(factory.CreateNestedEnum(declaringType, nestedType));
                        break;
                    case TypeClassification.Interface:
                        nestedInterfaces.Add(factory.CreateNestedInterface(declaringType, nestedType));
                        break;
                    case TypeClassification.Struct:
                        nestedStructs.Add(factory.CreateNestedStruct(declaringType, nestedType));
                        break;
                }
            }

            NestedClasses = nestedClasses;
            NestedDelegates = nestedDelegates;
            NestedEnums = nestedEnums;
            NestedInterfaces = nestedInterfaces;
            NestedStructs = nestedStructs;
        }

        public IReadOnlyCollection<TNestedClass> NestedClasses { get; private set; }

        public IReadOnlyCollection<TNestedDelegate> NestedDelegates { get; private set; }

        public IReadOnlyCollection<TNestedEnum> NestedEnums { get; private set; }

        public IReadOnlyCollection<TNestedInterface> NestedInterfaces { get; private set; }

        public IReadOnlyCollection<TNestedStruct> NestedStructs { get; private set; }
    }
}
