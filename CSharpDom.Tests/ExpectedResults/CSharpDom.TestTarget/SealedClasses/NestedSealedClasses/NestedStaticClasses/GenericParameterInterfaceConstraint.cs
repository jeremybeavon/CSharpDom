namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
