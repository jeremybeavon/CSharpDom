namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
