namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class<T>
            where T : BaseClass
        {
        }
    }
}
