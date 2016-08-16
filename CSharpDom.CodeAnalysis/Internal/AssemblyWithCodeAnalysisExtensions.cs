using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal static class AssemblyWithCodeAnalysisExtensions
    {
        public static TypeReference GetTypeReference(this AssemblyWithCodeAnalysis assembly, Type type)
        {
            return assembly.Assembly.MainModule.Import(type);
        }
    }
}
