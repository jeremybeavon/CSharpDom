namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
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
