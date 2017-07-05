namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
