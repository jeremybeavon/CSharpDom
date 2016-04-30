namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStructWith2GenericParameters
    {
        public sealed class Class
        {
            public struct NestedStruct<TKey, TValue>
            {
            }
        }
    }
}
