namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
