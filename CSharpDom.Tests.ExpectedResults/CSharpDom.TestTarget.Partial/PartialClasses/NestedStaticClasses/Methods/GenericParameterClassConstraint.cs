namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Methods
{
    public partial class PartialClassWithNestedStaticClassWithMethodWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
