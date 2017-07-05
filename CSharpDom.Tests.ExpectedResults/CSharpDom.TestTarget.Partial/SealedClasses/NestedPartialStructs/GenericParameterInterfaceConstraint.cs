namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
