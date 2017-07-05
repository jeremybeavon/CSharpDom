namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Methods
{
    public static class StaticClassWithNestedStaticPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public static T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
