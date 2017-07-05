namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
