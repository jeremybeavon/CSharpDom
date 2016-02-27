using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedTypes<
        TNestedAbstractClass,
        TNestedClass,
        TNestedSealedClass,
        TNestedStaticClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct>
    {
        public NestedTypes(
            ITypeWithMonoCecil declaringType,
            INestedTypeFactory<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> factory)
        {
            List<TNestedAbstractClass> nestedAbstractClasses = new List<TNestedAbstractClass>();
            List<TNestedClass> nestedClasses = new List<TNestedClass>();
            List<TNestedSealedClass> nestedSealedClasses = new List<TNestedSealedClass>();
            List<TNestedStaticClass> nestedStaticClasses = new List<TNestedStaticClass>();
            List<TNestedDelegate> nestedDelegates = new List<TNestedDelegate>();
            List<TNestedEnum> nestedEnums = new List<TNestedEnum>();
            List<TNestedInterface> nestedInterfaces = new List<TNestedInterface>();
            List<TNestedStruct> nestedStructs = new List<TNestedStruct>();
            foreach (Type nestedType in declaringType.Type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
            {
                switch (nestedType.TypeClassification())
                {
                    case TypeClassification.AbstractClass:
                        nestedAbstractClasses.Add(factory.CreateNestedAbstractClass(declaringType, nestedType));
                        break;
                    case TypeClassification.Class:
                        nestedClasses.Add(factory.CreateNestedClass(declaringType, nestedType));
                        break;
                    case TypeClassification.SealedClass:
                        nestedSealedClasses.Add(factory.CreateNestedSealedClass(declaringType, nestedType));
                        break;
                    case TypeClassification.StaticClass:
                        nestedStaticClasses.Add(factory.CreateNestedStaticClass(declaringType, nestedType));
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

            NestedAbstractClasses = nestedAbstractClasses;
            NestedClasses = nestedClasses;
            NestedSealedClasses = nestedSealedClasses;
            NestedStaticClasses = nestedStaticClasses;
            NestedDelegates = nestedDelegates;
            NestedEnums = nestedEnums;
            NestedInterfaces = nestedInterfaces;
            NestedStructs = nestedStructs;
        }

        public IReadOnlyCollection<TNestedAbstractClass> NestedAbstractClasses { get; private set; }

        public IReadOnlyCollection<TNestedClass> NestedClasses { get; private set; }

        public IReadOnlyCollection<TNestedSealedClass> NestedSealedClasses { get; private set; }

        public IReadOnlyCollection<TNestedStaticClass> NestedStaticClasses { get; private set; }

        public IReadOnlyCollection<TNestedDelegate> NestedDelegates { get; private set; }

        public IReadOnlyCollection<TNestedEnum> NestedEnums { get; private set; }

        public IReadOnlyCollection<TNestedInterface> NestedInterfaces { get; private set; }

        public IReadOnlyCollection<TNestedStruct> NestedStructs { get; private set; }
    }
}
