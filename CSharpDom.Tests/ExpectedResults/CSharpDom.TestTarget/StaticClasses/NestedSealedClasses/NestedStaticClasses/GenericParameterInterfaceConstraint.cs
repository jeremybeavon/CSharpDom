namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
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
