using System.Reflection;

namespace CSharpDom.Reflection
{
    public static class MethodInfoExtensions
    {
        public static bool IsOverride(this MethodInfo method)
        {
            return method.GetBaseDefinition().DeclaringType != method.DeclaringType;
        }
    }
}
