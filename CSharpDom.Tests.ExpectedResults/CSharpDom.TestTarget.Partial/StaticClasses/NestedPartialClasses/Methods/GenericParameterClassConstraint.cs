namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods
{
    public static class StaticClassWithNestedPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
