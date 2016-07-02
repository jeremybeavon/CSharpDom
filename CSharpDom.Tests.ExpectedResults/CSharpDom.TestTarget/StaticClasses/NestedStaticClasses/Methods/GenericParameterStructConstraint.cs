namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Methods
{
    public static class StaticClassWithNestedStaticClassWithMethodWithGenericParameterStructConstraint
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
