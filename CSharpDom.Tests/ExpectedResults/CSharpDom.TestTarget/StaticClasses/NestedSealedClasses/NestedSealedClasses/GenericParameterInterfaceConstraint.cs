namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
