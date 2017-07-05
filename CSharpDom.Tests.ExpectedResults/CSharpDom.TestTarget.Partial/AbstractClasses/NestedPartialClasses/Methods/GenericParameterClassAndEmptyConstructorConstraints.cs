namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
