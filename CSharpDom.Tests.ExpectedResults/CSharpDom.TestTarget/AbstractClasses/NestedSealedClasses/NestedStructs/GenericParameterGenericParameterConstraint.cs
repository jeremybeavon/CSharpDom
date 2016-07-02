namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
