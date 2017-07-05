namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
