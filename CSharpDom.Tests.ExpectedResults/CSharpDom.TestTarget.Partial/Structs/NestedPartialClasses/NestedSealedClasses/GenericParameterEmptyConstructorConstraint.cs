namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
