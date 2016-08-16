namespace CSharpDom.CodeAnalysis.Internal.Hiding
{
    internal static class ReturnTypeSignature
    {
        public static ITypeReferenceWithCodeAnalysis GetReturnType(AssemblyWithCodeAnalysis assembly)
        {
            return TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, assembly.Assembly.MainModule.TypeSystem.Object);
        }
    }
}
