namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
