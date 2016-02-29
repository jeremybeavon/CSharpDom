namespace CSharpDom.Mono.Cecil.Internal.Hiding
{
    internal static class ReturnTypeSignature
    {
        public static ITypeReferenceWithMonoCecil GetReturnType(AssemblyWithMonoCecil assembly)
        {
            return TypeReferenceWithMonoCecilFactory.CreateReference(assembly, assembly.Assembly.MainModule.TypeSystem.Object);
        }
    }
}
