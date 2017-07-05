namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
