namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
