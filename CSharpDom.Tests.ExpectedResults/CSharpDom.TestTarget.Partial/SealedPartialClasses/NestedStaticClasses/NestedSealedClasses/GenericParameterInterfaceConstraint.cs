namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
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
