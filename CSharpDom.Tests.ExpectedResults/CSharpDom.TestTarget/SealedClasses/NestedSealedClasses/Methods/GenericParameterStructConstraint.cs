namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods
{
    public sealed class SealedClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
