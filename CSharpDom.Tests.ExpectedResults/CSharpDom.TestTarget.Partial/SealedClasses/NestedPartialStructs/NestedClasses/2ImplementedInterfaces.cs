namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedPartialClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
