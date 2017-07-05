namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
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
