namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithPrivateNestedSealedClass
    {
        public struct Struct
        {
            private sealed class NestedClass
            {
            }
        }
    }
}
