namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
