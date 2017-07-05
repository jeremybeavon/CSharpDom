namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
