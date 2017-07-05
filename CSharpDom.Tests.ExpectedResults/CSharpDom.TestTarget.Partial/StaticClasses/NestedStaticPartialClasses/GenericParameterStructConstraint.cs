namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
