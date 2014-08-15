using System;
using CSharpDom.Common;

namespace CSharpDom.WithReflection.Internal
{
    internal static class ReflectionHelper
    {
        public static Type FindType<T>(T type)
            where T : IHasName, ICanBeGeneric, IHasNamespace<INamespaceWithReflection>, IHasProject<IProjectWithReflection>
        {
            return BuildTypeReference(type).Type;
        }

        public static Type FindNestedType<T>(T type)
            where T : IHasName, ICanBeGeneric, IHasDeclaringType<ITypeWithReflection>
        {
            return BuildNestedTypeReference(type).Type;
        }

        private static TypeReference BuildTypeReference<T>(T type)
            where T : IHasName, ICanBeGeneric, IHasNamespace<INamespaceWithReflection>, IHasProject<IProjectWithReflection>
        {
            string typeName = BuildTypeName(type.Namespace.Name, type.Name, type.GenericParameterCount);
            return new TypeReference(typeName, type.Project.Assembly);
        }

        private static TypeReference BuildNestedTypeReference<T>(T type)
            where T : IHasName, ICanBeGeneric, IHasDeclaringType<ITypeWithReflection>
        {
            ITypeWithReflection declaringType = type.DeclaringType;
            TypeReference typeReference;
            if (declaringType.IsNestedType)
            {
                typeReference = BuildNestedTypeReference((T)declaringType);
            }
            else
            {
                typeReference = BuildUnnestedTypeReference(declaringType);
            }

            string typeName = typeReference.TypeName + "+" + BuildTypeName(type.Name, type.GenericParameterCount);
            return new TypeReference(typeName, typeReference.Assembly);
        }

        private static TypeReference BuildUnnestedTypeReference(ITypeWithReflection declaringType)
        {
            IClassDeclarationWithReflection declaringClassDeclaration =
                declaringType as IClassDeclarationWithReflection;
            if (declaringClassDeclaration != null)
            {
                return BuildTypeReference(declaringClassDeclaration.CompositeType);
            }

            IStructDeclarationWithReflection declaringStructDeclaration =
                declaringType as IStructDeclarationWithReflection;
            if (declaringStructDeclaration != null)
            {
                return BuildTypeReference(declaringStructDeclaration.CompositeType);
            }

            IClassWithReflection declaringClass = declaringType as IClassWithReflection;
            if (declaringClass != null)
            {
                return BuildTypeReference(declaringClass);
            }

            IStructWithReflection declaringStruct = declaringType as IStructWithReflection;
            if (declaringStruct != null)
            {
                return BuildTypeReference(declaringStruct);
            }

            throw new NotSupportedException();
        }

        private static string BuildTypeName(string typeName, int genericParameterCount)
        {
            string fullName = typeName;
            if (genericParameterCount != 0)
            {
                fullName += "`" + genericParameterCount;
            }

            return fullName;
        }

        private static string BuildTypeName(string namespaceName, string typeName, int genericParameterCount)
        {
            return string.Format("{0}.{1}", namespaceName, BuildTypeName(typeName, genericParameterCount));
        }
    }
}
