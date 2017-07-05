namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
