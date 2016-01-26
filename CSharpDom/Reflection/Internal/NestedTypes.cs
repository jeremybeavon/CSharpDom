using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedTypes
    {
        public NestedTypes(ITypeWithReflection declaringType, Type type)
        {
            List<NestedClassWithReflection> nestedClasses = new List<NestedClassWithReflection>();
            List<NestedDelegateWithReflection> nestedDelegates = new List<NestedDelegateWithReflection>();
            List<NestedEnumWithReflection> nestedEnums = new List<NestedEnumWithReflection>();
            List<NestedInterfaceWithReflection> nestedInterfaces = new List<NestedInterfaceWithReflection>();
            List<NestedStructWithReflection> nestedStructs = new List<NestedStructWithReflection>();
            foreach (Type nestedType in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
            {
                switch (nestedType.TypeClassification())
                {
                    case TypeClassification.Class:
                        nestedClasses.Add(new NestedClassWithReflection(declaringType, nestedType));
                        break;
                    case TypeClassification.Delegate:
                        nestedDelegates.Add(new NestedDelegateWithReflection(declaringType, nestedType));
                        break;
                    case TypeClassification.Enum:
                        nestedEnums.Add(new NestedEnumWithReflection(declaringType, nestedType));
                        break;
                    case TypeClassification.Interface:
                        nestedInterfaces.Add(new NestedInterfaceWithReflection(declaringType, nestedType));
                        break;
                    case TypeClassification.Struct:
                        nestedStructs.Add(new NestedStructWithReflection(declaringType, nestedType));
                        break;
                }
            }

            NestedClasses = nestedClasses;
            NestedDelegates = nestedDelegates;
            NestedEnums = nestedEnums;
            NestedInterfaces = nestedInterfaces;
            NestedStructs = nestedStructs;
        }

        public IReadOnlyCollection<NestedClassWithReflection> NestedClasses { get; private set; }

        public IReadOnlyCollection<NestedDelegateWithReflection> NestedDelegates { get; private set; }

        public IReadOnlyCollection<NestedEnumWithReflection> NestedEnums { get; private set; }

        public IReadOnlyCollection<NestedInterfaceWithReflection> NestedInterfaces { get; private set; }

        public IReadOnlyCollection<NestedStructWithReflection> NestedStructs { get; private set; }
    }
}
