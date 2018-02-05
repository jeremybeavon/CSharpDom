namespace CSharpDom.CodeAnalysis
{
    public static class TypeReferenceFactory
    {
        public static ClassReferenceWithCodeAnalysis Class(
            string name,
            params ITypeReferenceWithCodeAnalysis[] genericParameters)
        {
            return new ClassReferenceWithCodeAnalysis(name, genericParameters);
        }
    }
}
