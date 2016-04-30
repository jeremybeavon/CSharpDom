namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
