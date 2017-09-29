namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedSealedClasses
{
    public partial struct PartialStructWithNestedStructWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
