namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods
{
    public sealed class SealedClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
