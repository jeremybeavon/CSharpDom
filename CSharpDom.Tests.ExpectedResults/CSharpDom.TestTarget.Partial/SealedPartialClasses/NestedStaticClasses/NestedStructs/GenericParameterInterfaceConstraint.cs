namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
