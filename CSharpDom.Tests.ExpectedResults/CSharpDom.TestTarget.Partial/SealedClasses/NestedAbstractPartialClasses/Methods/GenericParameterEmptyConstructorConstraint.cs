namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
