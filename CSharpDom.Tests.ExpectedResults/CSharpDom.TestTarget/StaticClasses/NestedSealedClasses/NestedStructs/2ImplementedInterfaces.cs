namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces
    {
        public sealed class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
