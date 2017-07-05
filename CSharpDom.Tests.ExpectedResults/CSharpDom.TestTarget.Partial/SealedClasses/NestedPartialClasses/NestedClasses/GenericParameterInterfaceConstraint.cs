namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
