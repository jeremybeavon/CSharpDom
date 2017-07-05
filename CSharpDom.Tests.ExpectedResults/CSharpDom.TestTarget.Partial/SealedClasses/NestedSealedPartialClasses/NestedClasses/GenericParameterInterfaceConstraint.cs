namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
