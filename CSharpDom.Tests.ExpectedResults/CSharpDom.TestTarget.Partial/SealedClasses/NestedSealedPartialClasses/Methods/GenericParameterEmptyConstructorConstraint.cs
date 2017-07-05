namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedSealedPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
