namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
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
