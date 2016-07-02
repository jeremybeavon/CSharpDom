namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods
{
    public abstract class AbstractClassWithNestedClassWithMethodWithGenericParameterClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
