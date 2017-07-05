namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
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
