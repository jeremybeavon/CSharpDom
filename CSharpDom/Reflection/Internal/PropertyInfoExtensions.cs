using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class PropertyInfoExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this PropertyInfo property)
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

        public static StructMemberVisibilityModifier StructVisibility(this PropertyInfo property)
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

        public static ClassMemberInheritanceModifier InheritanceModifier(this PropertyInfo property)
        {
            return (property.GetMethod ?? property.SetMethod).InheritanceModifier();
        }

        private static ClassMemberVisibilityModifier? ClassVisibility(MethodInfo method)
        {
            return method == null ? (ClassMemberVisibilityModifier?)null : method.ClassVisibility();
        }

        private static StructMemberVisibilityModifier? StructVisibility(MethodInfo method)
        {
            return method == null ? (StructMemberVisibilityModifier?)null : method.StructVisibility();
        }
    }
}
