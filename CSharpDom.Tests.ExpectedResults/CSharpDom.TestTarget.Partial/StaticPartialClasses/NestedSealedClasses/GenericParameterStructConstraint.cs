namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
