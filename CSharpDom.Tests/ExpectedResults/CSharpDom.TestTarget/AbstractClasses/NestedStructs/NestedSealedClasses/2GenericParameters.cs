namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedClassWith2GenericParameters
    {
        public struct Struct
        {
            public sealed class NestedClass<TKey, TValue>
            {
            }
        }
    }
}
