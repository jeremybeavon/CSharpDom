namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithMethodWithGenericParameterClassConstraint
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
