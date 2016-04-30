namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint
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
