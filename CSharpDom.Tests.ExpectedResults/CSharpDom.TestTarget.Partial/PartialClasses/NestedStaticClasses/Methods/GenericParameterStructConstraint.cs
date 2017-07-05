namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Methods
{
    public partial class PartialClassWithNestedStaticClassWithMethodWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
