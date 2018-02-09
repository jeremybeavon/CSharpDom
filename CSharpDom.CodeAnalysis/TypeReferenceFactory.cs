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

        public static DelegateReferenceWithCodeAnalysis Delegate(
            string name,
            params ITypeReferenceWithCodeAnalysis[] genericParameters)
        {
            return new DelegateReferenceWithCodeAnalysis(name, genericParameters);
        }

        public static GenericParameterReferenceWithCodeAnalysis GenericParameter(string name)
        {
            return new GenericParameterReferenceWithCodeAnalysis(name);
        }

        public static InterfaceReferenceWithCodeAnalysis Interface(
            string name,
            params ITypeReferenceWithCodeAnalysis[] genericParameters)
        {
            return new InterfaceReferenceWithCodeAnalysis(name, genericParameters);
        }
    }
}
