using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class PropertyInfoExtensions
    {
        public static MemberVisibilityModifier Visibility(this PropertyInfo property)
        {
            MemberVisibilityModifier? getVisibility = Visibility(property.GetMethod);
            MemberVisibilityModifier? setVisibility = Visibility(property.SetMethod);
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

        public static MemberInheritanceModifier InheritanceModifier(this PropertyInfo property)
        {
            return (property.GetMethod ?? property.SetMethod).InheritanceModifier();
        }

        private static MemberVisibilityModifier? Visibility(MethodInfo method)
        {
            return method == null ? (MemberVisibilityModifier?)null : method.Visibility();
        }
    }
}
