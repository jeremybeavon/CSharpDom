using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class PropertyInfoExtensions
    {
        public static ClassMemberVisibilityModifier Visibility(this PropertyInfo property)
        {
            ClassMemberVisibilityModifier? getVisibility = Visibility(property.GetMethod);
            ClassMemberVisibilityModifier? setVisibility = Visibility(property.SetMethod);
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

        private static ClassMemberVisibilityModifier? Visibility(MethodInfo method)
        {
            return method == null ? (ClassMemberVisibilityModifier?)null : method.Visibility();
        }
    }
}
