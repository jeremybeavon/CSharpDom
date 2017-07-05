namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed partial class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
