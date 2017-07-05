namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
