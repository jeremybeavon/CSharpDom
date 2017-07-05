namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
