namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
