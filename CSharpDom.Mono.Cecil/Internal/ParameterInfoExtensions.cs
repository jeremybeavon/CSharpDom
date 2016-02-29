using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class ParameterDefinitionExtensions
    {
        public static ParameterModifier Modifier(this ParameterDefinition parameter, AssemblyWithMonoCecil assembly)
        {
            if (parameter.IsOut)
            {
                return ParameterModifier.Out;
            }

            if (parameter.ParameterType.IsByReference)
            {
                return ParameterModifier.Ref;
            }

            if (parameter.IsDefined(assembly, typeof(ParamArrayAttribute)))
            {
                return ParameterModifier.Params;
            }

            return ParameterModifier.None;
        }
    }
}
