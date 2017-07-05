namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
