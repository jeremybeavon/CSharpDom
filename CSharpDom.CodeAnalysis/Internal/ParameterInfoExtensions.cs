using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal static class ParameterDefinitionExtensions
    {
        public static ParameterModifier Modifier(this ParameterDefinition parameter, AssemblyWithCodeAnalysis assembly)
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
