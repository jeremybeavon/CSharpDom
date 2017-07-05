namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedPartialClassWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
