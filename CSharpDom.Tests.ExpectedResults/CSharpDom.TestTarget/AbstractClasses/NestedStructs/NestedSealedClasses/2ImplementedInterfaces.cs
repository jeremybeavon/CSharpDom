namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public sealed class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
