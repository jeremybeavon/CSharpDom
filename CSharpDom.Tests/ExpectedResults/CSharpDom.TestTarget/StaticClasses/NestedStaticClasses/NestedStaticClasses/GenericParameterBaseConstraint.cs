namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
