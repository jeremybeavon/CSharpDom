namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
