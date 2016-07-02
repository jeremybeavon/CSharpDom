namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedClassWithBaseClass
    {
        public struct Struct
        {
            public sealed class NestedClass : BaseClass
            {
            }
        }
    }
}
