namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStructs
{
    public partial class PartialClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
