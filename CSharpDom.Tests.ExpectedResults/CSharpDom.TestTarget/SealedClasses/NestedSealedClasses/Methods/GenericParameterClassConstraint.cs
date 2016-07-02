namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods
{
    public sealed class SealedClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
