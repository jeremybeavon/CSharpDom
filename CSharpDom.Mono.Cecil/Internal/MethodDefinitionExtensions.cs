using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class MethodDefinitionExtensions
    {
        public static ClassMemberInheritanceModifier InheritanceModifier(this MethodDefinition method, IInternalTypeWithMonoCecil type)
        {
            return method.InheritanceModifier(() => type.HiddenMembersAnalyzer.IsMethodHidden(method));
        }

        public static SealedClassMemberInheritanceModifier SealedClassInheritanceModifier(this MethodDefinition method, IInternalTypeWithMonoCecil type)
        {
            return method.SealedClassInheritanceModifier(() => type.HiddenMembersAnalyzer.IsMethodHidden(method));
        }

        public static SealedClassMemberInheritanceModifier SealedClassInheritanceModifier(this MethodDefinition method, Func<bool> isHidden)
        {
            switch (method.InheritanceModifier(isHidden))
            {
                case ClassMemberInheritanceModifier.New:
                    return SealedClassMemberInheritanceModifier.New;
                case ClassMemberInheritanceModifier.NewStatic:
                    return SealedClassMemberInheritanceModifier.NewStatic;
                case ClassMemberInheritanceModifier.None:
                    return SealedClassMemberInheritanceModifier.None;
                case ClassMemberInheritanceModifier.Override:
                    return SealedClassMemberInheritanceModifier.Override;
                case ClassMemberInheritanceModifier.SealedOverride:
                    return SealedClassMemberInheritanceModifier.SealedOverride;
                case ClassMemberInheritanceModifier.Static:
                    return SealedClassMemberInheritanceModifier.Static;
                default:
                    throw new NotSupportedException();
            }
        }

        public static ClassMemberInheritanceModifier InheritanceModifier(this MethodDefinition method, Func<bool> isHidden)
        {
            if (method.IsFinal && method.HasOverrides)
            {
                return ClassMemberInheritanceModifier.SealedOverride;
            }

            if (method.HasOverrides)
            {
                return ClassMemberInheritanceModifier.Override;
            }

            if (isHidden())
            {
                if (method.IsStatic)
                {
                    return ClassMemberInheritanceModifier.NewStatic;
                }

                if (method.IsVirtual)
                {
                    return ClassMemberInheritanceModifier.NewVirtual;
                }

                return ClassMemberInheritanceModifier.New;
            }

            if (method.IsStatic)
            {
                return ClassMemberInheritanceModifier.Static;
            }
            
            if (method.IsVirtual)
            {
                return ClassMemberInheritanceModifier.Virtual;
            }

            return ClassMemberInheritanceModifier.None;
        }

        public static ClassMemberVisibilityModifier ClassVisibility(this MethodDefinition method)
        {
            if (method.IsPublic)
            {
                return ClassMemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return ClassMemberVisibilityModifier.Internal;
            }

            if (method.IsFamilyOrAssembly)
            {
                return ClassMemberVisibilityModifier.ProtectedInternal;
            }

            if (method.IsFamily)
            {
                return ClassMemberVisibilityModifier.Protected;
            }

            if (method.IsPrivate)
            {
                return ClassMemberVisibilityModifier.Private;
            }

            return ClassMemberVisibilityModifier.None;
        }

        public static StructMemberVisibilityModifier StructVisibility(this MethodDefinition method)
        {
            if (method.IsPublic)
            {
                return StructMemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return StructMemberVisibilityModifier.Internal;
            }

            if (method.IsPrivate)
            {
                return StructMemberVisibilityModifier.Private;
            }

            return StructMemberVisibilityModifier.None;
        }

        public static StaticClassMemberVisibilityModifier StaticClassVisibility(this MethodDefinition method)
        {
            if (method.IsPublic)
            {
                return StaticClassMemberVisibilityModifier.Public;
            }

            if (method.IsAssembly)
            {
                return StaticClassMemberVisibilityModifier.Internal;
            }

            if (method.IsPrivate)
            {
                return StaticClassMemberVisibilityModifier.Private;
            }

            return StaticClassMemberVisibilityModifier.None;
        }
    }
}
