using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection.Internal
{
    internal static class ReflectionMemberHelper
    {
        public const BindingFlags Flags =
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly;

        public const BindingFlags InstanceFlags =
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly;

        private const BindingFlags StaticFlags =
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Static |
            BindingFlags.DeclaredOnly;

        private static readonly Regex GenericTypeNameRegex = new Regex(@"^(?<TypeName>\w+)`\d+$", RegexOptions.Compiled);

        private static readonly IDictionary<TypeCode, string> PredefinedTypes =
            new Dictionary<TypeCode, string>()
        {
            { TypeCode.Boolean, "bool" },
            { TypeCode.Byte, "byte" },
            { TypeCode.Char, "char" },
            { TypeCode.DateTime, "System.DateTime" },
            { TypeCode.DBNull, "System.DBNull" },
            { TypeCode.Decimal, "decimal" },
            { TypeCode.Double, "double" },
            { TypeCode.Int16, "short" },
            { TypeCode.Int32, "int" },
            { TypeCode.Int64, "long" },
            { TypeCode.SByte, "sbyte" },
            { TypeCode.Single, "float" },
            { TypeCode.String, "string" },
            { TypeCode.UInt16, "ushort" },
            { TypeCode.UInt32, "uint" },
            { TypeCode.UInt64, "ulong" }
        };

        public static TMember ValidateMember<TMember>(IReadOnlyList<TMember> members)
        {
            if (members.Count == 0)
            {
                throw new InvalidOperationException("No member found.");
            }

            if (members.Count > 1)
            {
                throw new InvalidOperationException("Too many members found.");
            }

            return members[0];
        }

        public static bool IsMatch(ParameterInfo[] parameters, ImmutableArray<IParameterSymbol> parameterSymbols)
        {
            if (parameters.Length != parameterSymbols.Length)
            {
                return false;
            }

            for (int index = 0; index < parameters.Length; index++)
            {
                ParameterInfo parameter = parameters[index];
                IParameterSymbol parameterSymbol = parameterSymbols[index];
                StringBuilder typeNameBuilder = new StringBuilder();
                BuildRefOrOutOrParams(parameter, typeNameBuilder);
                BuildTypeName(parameter.ParameterType, typeNameBuilder);
                if (typeNameBuilder.ToString() != parameterSymbol.ToDisplayString())
                {
                    return false;
                }
            }

            return true;
        }

        public static MethodInfo FindMethod<T>(T method)
            where T : IHasDeclaringType<IBasicTypeWithReflection>, IHasSymbol<IMethodSymbol>
        {
            return FindMethod(method, method.DeclaringType, Flags);
        }

        public static MethodInfo FindStaticMethod<T>(T method)
            where T : IHasDeclaringType<ITypeWithReflection>, IHasSymbol<IMethodSymbol>
        {
            return FindMethod(method, method.DeclaringType, StaticFlags);
        }

        private static MethodInfo FindMethod(
            IHasSymbol<IMethodSymbol> method,
            IHasType type,
            BindingFlags flags)
        {
            return FindMethod(type.Type.GetMethods(flags), method.Symbol);
        }

        private static MethodInfo FindMethod(MethodInfo[] methods, IMethodSymbol methodSymbol)
        {
            return ValidateMember(methods.Where(method => IsMatch(method, methodSymbol)).ToArray());
        }

        private static bool IsMatch(MethodInfo method, IMethodSymbol methodSymbol)
        {
            return method.Name == methodSymbol.Name &&
                method.GetGenericArguments().Length == methodSymbol.Arity &&
                IsMatch(method.GetParameters(), methodSymbol.Parameters);
        }

        private static void BuildRefOrOutOrParams(ParameterInfo parameter, StringBuilder typeNameBuilder)
        {
            if (parameter.IsOut)
            {
                typeNameBuilder.Append("out ");
            }
            else if (parameter.ParameterType.IsByRef)
            {
                typeNameBuilder.Append("ref ");
            }
            else if (Attribute.IsDefined(parameter, typeof(ParamArrayAttribute)))
            {
                typeNameBuilder.Append("params ");
            }
        }

        private static string BuildTypeName(Type type)
        {
            StringBuilder typeNameBuilder = new StringBuilder();
            BuildTypeName(type, typeNameBuilder);
            return typeNameBuilder.ToString();
        }

        private static void BuildTypeName(Type type, StringBuilder typeNameBuilder)
        {
            if (type.IsByRef)
            {
                BuildTypeName(type.GetElementType(), typeNameBuilder);
            }
            else if (type.IsArray)
            {
                BuildArrayType(type, typeNameBuilder);
            }
            else
            {
                BuildTypeName(type, typeNameBuilder, Type.GetTypeCode(type));
            }
        }

        private static void BuildTypeName(Type type, StringBuilder typeNameBuilder, TypeCode typeCode)
        {
            if (typeCode != TypeCode.Object)
            {
                typeNameBuilder.Append(PredefinedTypes[typeCode]);
                return;
            }
            else if (type == typeof(object))
            {
                typeNameBuilder.Append("object");
                return;
            }

            IEnumerable<Type> genericArguments = BuildNamespaceOrNestedType(type, typeNameBuilder);
            if (type.IsGenericType)
            {
                BuildGenericTypeName(type, typeNameBuilder, genericArguments ?? type.GetGenericArguments());
            }
            else
            {
                typeNameBuilder.Append(type.Name);
            }
        }

        private static IEnumerable<Type> BuildNamespaceOrNestedType(Type type, StringBuilder typeNameBuilder)
        {
            IEnumerable<Type> genericArguments = null;
            if (!type.IsGenericParameter)
            {
                Type declaringType = type.DeclaringType;
                if (declaringType != null)
                {
                    genericArguments = BuildNestedType(
                        declaringType,
                        typeNameBuilder,
                        new ArraySegment<Type>(type.GetGenericArguments()));
                }
                else
                {
                    typeNameBuilder.Append(type.Namespace + ".");
                }
            }

            return genericArguments;
        }

        private static ArraySegment<Type> BuildNestedType(
            Type type,
            StringBuilder typeNameBuilder,
            ArraySegment<Type> genericArguments)
        {
            if (type.DeclaringType != null)
            {
                genericArguments = BuildNestedType(type.DeclaringType, typeNameBuilder, genericArguments);
            }
            else
            {
                typeNameBuilder.Append(type.Namespace + ".");
            }

            genericArguments = BuildNestedTypeName(type, typeNameBuilder, genericArguments);
            typeNameBuilder.Append(".");
            return genericArguments;
        }

        private static ArraySegment<Type> BuildNestedTypeName(
            Type type,
            StringBuilder typeNameBuilder,
            ArraySegment<Type> genericArguments)
        {
            if (type.IsGenericType)
            {
                int length = genericArguments.Count;
                genericArguments = new ArraySegment<Type>(
                    genericArguments.Array,
                    genericArguments.Offset,
                    type.GetGenericArguments().Length);
                BuildGenericTypeName(type, typeNameBuilder, genericArguments);
                int offset = genericArguments.Offset + genericArguments.Count;
                genericArguments = new ArraySegment<Type>(genericArguments.Array, offset, length - offset);
            }
            else
            {
                typeNameBuilder.Append(type.Name);
            }

            return genericArguments;
        }

        private static void BuildGenericTypeName(
            Type type,
            StringBuilder typeNameBuilder,
            IEnumerable<Type> genericArguments)
        {
            typeNameBuilder.Append(GenericTypeNameRegex.Match(type.Name).Groups["TypeName"].Value);
            typeNameBuilder.Append("<");
            string comma = string.Empty;
            foreach (Type genericParameter in genericArguments)
            {
                typeNameBuilder.Append(comma);
                BuildTypeName(genericParameter, typeNameBuilder);
                comma = ", ";
            }

            typeNameBuilder.Append(">");
        }

        private static void BuildArrayType(Type type, StringBuilder typeNameBuilder)
        {
            Type arrayType = type;
            Queue<Type> elementTypeStack = new Queue<Type>();
            while (arrayType.IsArray)
            {
                elementTypeStack.Enqueue(arrayType);
                arrayType = arrayType.GetElementType();
            }
            
            BuildTypeName(arrayType, typeNameBuilder);
            while (elementTypeStack.Count != 0)
            {
                BuildArrayDimensions(elementTypeStack.Dequeue(), typeNameBuilder);
            }
        }

        private static void BuildArrayDimensions(Type type, StringBuilder typeNameBuilder)
        {
            int dimensions = type.GetArrayRank();
            if (dimensions == 1)
            {
                typeNameBuilder.Append("[]");
                return;
            }

            typeNameBuilder.Append("[*");
            for (int dimension = 1; dimension < dimensions; dimension++)
            {
                typeNameBuilder.Append(",*");
            }

            typeNameBuilder.Append("]");
        }
    }
}
