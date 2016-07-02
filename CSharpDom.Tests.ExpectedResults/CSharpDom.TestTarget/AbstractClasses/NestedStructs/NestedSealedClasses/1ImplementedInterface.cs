namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedClassWith1ImplementedInterface
    {
        public struct Struct
        {
            public sealed class NestedClass : IInterface
            {
            }
        }
    }
}
