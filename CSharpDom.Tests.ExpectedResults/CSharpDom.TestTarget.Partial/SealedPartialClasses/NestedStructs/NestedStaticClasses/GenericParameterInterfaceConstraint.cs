namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterInterfaceConstraint
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
