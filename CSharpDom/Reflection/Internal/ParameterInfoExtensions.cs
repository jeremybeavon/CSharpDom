using System;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class ParameterInfoExtensions
    {
        public static ParameterModifier Modifier(this ParameterInfo parameter)
        {
            if (parameter.IsOut)
            {
                return ParameterModifier.Out;
            }

            if (parameter.ParameterType.IsByRef)
            {
                return ParameterModifier.Ref;
            }

            if (parameter.IsDefined(typeof(ParamArrayAttribute)))
            {
                return ParameterModifier.Params;
            }

            return ParameterModifier.None;
        }
    }
}
