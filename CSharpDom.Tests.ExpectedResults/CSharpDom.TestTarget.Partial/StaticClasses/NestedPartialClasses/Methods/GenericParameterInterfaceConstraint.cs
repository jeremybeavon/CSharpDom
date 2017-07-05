namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Methods
{
    public static class StaticClassWithNestedPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
