namespace CSharpDom.TestTarget.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
