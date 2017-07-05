namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class<T>
            where T : IInterface
        {
        }
    }
}
