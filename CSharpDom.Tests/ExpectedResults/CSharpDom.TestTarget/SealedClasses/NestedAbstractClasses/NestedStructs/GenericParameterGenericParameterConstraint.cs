namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
