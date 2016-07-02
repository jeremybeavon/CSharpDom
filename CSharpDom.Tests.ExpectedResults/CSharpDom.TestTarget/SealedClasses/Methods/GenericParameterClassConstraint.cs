namespace CSharpDom.TestTarget.SealedClasses.Methods
{
    public sealed class SealedClassWithMethodWithGenericParameterSealedClassConstraint
    {
        public T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
