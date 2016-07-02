namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
