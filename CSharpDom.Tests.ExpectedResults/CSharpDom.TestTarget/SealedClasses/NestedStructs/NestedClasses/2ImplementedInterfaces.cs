namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
