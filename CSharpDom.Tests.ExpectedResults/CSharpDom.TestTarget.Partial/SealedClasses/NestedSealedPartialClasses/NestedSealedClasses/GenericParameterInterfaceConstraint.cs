namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
