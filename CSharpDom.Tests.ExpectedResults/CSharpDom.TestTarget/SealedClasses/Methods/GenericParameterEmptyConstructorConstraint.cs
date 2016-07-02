namespace CSharpDom.TestTarget.SealedClasses.Methods
{
    public sealed class SealedClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public T Method<T>()
            where T : new()
        {
            return default(T);
        }
    }
}
