namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
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
