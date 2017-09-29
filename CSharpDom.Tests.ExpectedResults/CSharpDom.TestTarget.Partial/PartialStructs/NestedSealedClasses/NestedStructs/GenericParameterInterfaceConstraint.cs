namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStructs
{
    public partial struct PartialStructWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
