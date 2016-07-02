namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods
{
    public abstract class AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
