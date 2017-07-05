namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedPartialClassWithNestedSealedPartialClassWith2ImplementedInterfaces
    {
        public partial class Class
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
