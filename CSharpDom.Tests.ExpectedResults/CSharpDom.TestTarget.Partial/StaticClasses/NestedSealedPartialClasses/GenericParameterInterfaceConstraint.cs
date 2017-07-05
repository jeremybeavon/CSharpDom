namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
