namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
