namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
