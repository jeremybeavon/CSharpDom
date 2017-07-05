namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
