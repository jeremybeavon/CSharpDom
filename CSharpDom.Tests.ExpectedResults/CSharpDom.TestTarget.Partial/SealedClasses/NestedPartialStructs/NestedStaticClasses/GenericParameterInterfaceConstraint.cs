namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
