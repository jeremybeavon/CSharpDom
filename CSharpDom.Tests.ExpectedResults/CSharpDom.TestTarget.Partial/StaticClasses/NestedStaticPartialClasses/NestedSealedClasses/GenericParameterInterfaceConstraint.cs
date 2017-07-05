namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
