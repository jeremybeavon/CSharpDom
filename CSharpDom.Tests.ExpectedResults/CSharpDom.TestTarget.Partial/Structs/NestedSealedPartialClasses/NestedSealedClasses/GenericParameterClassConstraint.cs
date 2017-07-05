namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
