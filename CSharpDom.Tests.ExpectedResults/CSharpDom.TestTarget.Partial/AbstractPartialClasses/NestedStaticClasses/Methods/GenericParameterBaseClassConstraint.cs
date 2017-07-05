namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
