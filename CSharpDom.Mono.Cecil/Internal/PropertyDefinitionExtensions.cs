using Mono.Cecil;
using System;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class PropertyDefinitionExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this PropertyDefinition property)
        {
            ClassMemberVisibilityModifier? getVisibility = ClassVisibility(property.GetMethod);
            ClassMemberVisibilityModifier? setVisibility = ClassVisibility(property.SetMethod);
            if (getVisibility.HasValue && setVisibility.HasValue)
            {
                return (new[] { getVisibility.Value, setVisibility.Value }).Min();
            }

            if (getVisibility.HasValue)
            {
                return getVisibility.Value;
            }

            return setVisibility.Value;
        }

        public static StaticClassMemberVisibilityModifier StaticClassVisibility(this PropertyDefinition property)
        {
            StaticClassMemberVisibilityModifier? getVisibility = StaticClassVisibility(property.GetMethod);
            StaticClassMemberVisibilityModifier? setVisibility = StaticClassVisibility(property.SetMethod);
            if (getVisibility.HasValue && setVisibility.HasValue)
            {
                return (new[] { getVisibility.Value, setVisibility.Value }).Min();
            }

            if (getVisibility.HasValue)
            {
                return getVisibility.Value;
            }

            return setVisibility.Value;
        }

        public static StructMemberVisibilityModifier StructVisibility(this PropertyDefinition property)
        {
            StructMemberVisibilityModifier? getVisibility = StructVisibility(property.GetMethod);
            StructMemberVisibilityModifier? setVisibility = StructVisibility(property.SetMethod);
            if (getVisibility.HasValue && setVisibility.HasValue)
            {
                return (new[] { getVisibility.Value, setVisibility.Value }).Min();
            }

            if (getVisibility.HasValue)
            {
                return getVisibility.Value;
            }

            return setVisibility.Value;
        }

        public static ClassMemberInheritanceModifier InheritanceModifier(
            this PropertyDefinition property,
            IInternalTypeWithMonoCecil type)
        {
            return property.Method().PropertyOrEventInheritanceModifier(() => type.HiddenMembersAnalyzer.IsPropertyHidden(property));
        }

        public static SealedClassMemberInheritanceModifier SealedClassInheritanceModifier(
            this PropertyDefinition property,
            IInternalTypeWithMonoCecil type)
        {
            return property.Method().SealedClassInheritanceModifier(() => type.HiddenMembersAnalyzer.IsPropertyHidden(property));
        }

        public static IndexerInheritanceModifier IndexerInheritanceModifier(
            this PropertyDefinition property,
            IInternalTypeWithMonoCecil type)
        {
            switch (property.Method().InheritanceModifier(() => type.HiddenMembersAnalyzer.IsIndexerHidden(property)))
            {
                case ClassMemberInheritanceModifier.None:
                    return CSharpDom.IndexerInheritanceModifier.None;
                case ClassMemberInheritanceModifier.New:
                    return CSharpDom.IndexerInheritanceModifier.New;
                case ClassMemberInheritanceModifier.NewVirtual:
                    return CSharpDom.IndexerInheritanceModifier.NewVirtual;
                case ClassMemberInheritanceModifier.Override:
                    return CSharpDom.IndexerInheritanceModifier.Override;
                case ClassMemberInheritanceModifier.SealedOverride:
                    return CSharpDom.IndexerInheritanceModifier.SealedOverride;
                case ClassMemberInheritanceModifier.Virtual:
                    return CSharpDom.IndexerInheritanceModifier.Virtual;
                default:
                    throw new NotSupportedException();
            }
        }

        public static SealedClassIndexerInheritanceModifier SealedClassIndexerInheritanceModifier(
            this PropertyDefinition property,
            IInternalTypeWithMonoCecil type)
        {
            switch (property.Method().InheritanceModifier(() => type.HiddenMembersAnalyzer.IsIndexerHidden(property)))
            {
                case ClassMemberInheritanceModifier.None:
                    return CSharpDom.SealedClassIndexerInheritanceModifier.None;
                case ClassMemberInheritanceModifier.New:
                    return CSharpDom.SealedClassIndexerInheritanceModifier.New;
                case ClassMemberInheritanceModifier.Override:
                    return CSharpDom.SealedClassIndexerInheritanceModifier.Override;
                case ClassMemberInheritanceModifier.SealedOverride:
                    return CSharpDom.SealedClassIndexerInheritanceModifier.SealedOverride;
                default:
                    throw new NotSupportedException();
            }
        }

        public static bool IsOverride(this PropertyDefinition property)
        {
            return property.Method().HasOverrides;
        }

        internal static MethodDefinition Method(this PropertyDefinition property)
        {
            return property.GetMethod ?? property.SetMethod;
        }

        private static ClassMemberVisibilityModifier? ClassVisibility(MethodDefinition method)
        {
            return method == null ? (ClassMemberVisibilityModifier?)null : method.ClassVisibility();
        }

        private static StaticClassMemberVisibilityModifier? StaticClassVisibility(MethodDefinition method)
        {
            return method == null ? (StaticClassMemberVisibilityModifier?)null : method.StaticClassVisibility();
        }

        private static StructMemberVisibilityModifier? StructVisibility(MethodDefinition method)
        {
            return method == null ? (StructMemberVisibilityModifier?)null : method.StructVisibility();
        }
    }
}
