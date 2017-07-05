namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
