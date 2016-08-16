using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public static class TypeReferenceWithCodeAnalysisFactory
    {
        private static readonly IDictionary<Func<TypeSystem, TypeReference>, BuiltInType?> builtInTypes =
            new Dictionary<Func<TypeSystem, TypeReference>, BuiltInType?>()
            {
                { typeSystem => typeSystem.Boolean, BuiltInType.Bool },
                { typeSystem => typeSystem.Byte, BuiltInType.Byte },
                { typeSystem => typeSystem.Char, BuiltInType.Char },
                //{ typeSystem => typeSystem, BuiltInType.Decimal },
                { typeSystem => typeSystem.Double, BuiltInType.Double },
                { typeSystem => typeSystem.Single, BuiltInType.Float },
                { typeSystem => typeSystem.Int32, BuiltInType.Int },
                { typeSystem => typeSystem.Int64, BuiltInType.Long },
                { typeSystem => typeSystem.Object, BuiltInType.Object },
                { typeSystem => typeSystem.SByte, BuiltInType.SByte },
                { typeSystem => typeSystem.Int16, BuiltInType.Short },
                { typeSystem => typeSystem.String, BuiltInType.String },
                { typeSystem => typeSystem.UInt32, BuiltInType.UInt },
                { typeSystem => typeSystem.UInt64, BuiltInType.ULong },
                { typeSystem => typeSystem.UInt16, BuiltInType.UShort },
                { typeSystem => typeSystem.Void, BuiltInType.Void }
            };

        public static ITypeReferenceWithCodeAnalysis CreateReference(AssemblyWithCodeAnalysis assembly, TypeReference type, MemberReference member = null, bool ignoreNestedType = false)
        {
            if (type.IsByReference)
            {
                type = type.GetElementType();
            }

            if (type.IsArray)
            {
                return new ArrayTypeReferenceWithCodeAnalysis(assembly, type, member);
            }

            if (type.DeclaringType != null && !ignoreNestedType && (member == null || !IsParentType(type, member.DeclaringType)))
            {
                return new NestedTypeReferenceWithCodeAnalysis(assembly, type);
            }

            if (type.IsGenericParameter)
            {
                return new GenericParameterReferenceWithCodeAnalysis(type);
            }

            ITypeReferenceWithCodeAnalysis typeReference = CreateBuiltInReference(assembly, type);
            if (typeReference != null)
            {
                return typeReference;
            }

            switch (type.Resolve().TypeClassification())
            {
                case TypeClassification.AbstractClass:
                case TypeClassification.Class:
                case TypeClassification.SealedClass:
                case TypeClassification.StaticClass:
                    return new ClassReferenceWithCodeAnalysis(assembly, type);
                case TypeClassification.Delegate:
                    return new DelegateReferenceWithCodeAnalysis(assembly, type);
                case TypeClassification.Enum:
                    return new EnumReferenceWithCodeAnalysis(type);
                case TypeClassification.Interface:
                    return new InterfaceReferenceWithCodeAnalysis(assembly, type);
                case TypeClassification.Struct:
                    return new StructReferenceWithCodeAnalysis(assembly, type);
                default:
                    return new UnspecifiedTypeReferenceWithCodeAnalysis(assembly, type);
            }
        }

        private static bool IsParentType(TypeReference type, TypeReference parentType)
        {
            return parentType != null && (type.FullName == parentType.FullName || IsParentType(type, parentType.DeclaringType));
        }

        private static ITypeReferenceWithCodeAnalysis CreateBuiltInReference(AssemblyWithCodeAnalysis assembly, TypeReference type)
        {
            TypeSystem typeSystem = assembly.Assembly.MainModule.TypeSystem;
            BuiltInType? builtInType =
                (from entry in builtInTypes
                 let typeReference = entry.Key(typeSystem)
                 where typeReference == type
                 select entry.Value).FirstOrDefault();
            return builtInType.HasValue ? new BuiltInTypeReferenceWithCodeAnalysis(builtInType.Value, type) : null;
        }
    }
}
