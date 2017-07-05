namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
