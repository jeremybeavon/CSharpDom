namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
