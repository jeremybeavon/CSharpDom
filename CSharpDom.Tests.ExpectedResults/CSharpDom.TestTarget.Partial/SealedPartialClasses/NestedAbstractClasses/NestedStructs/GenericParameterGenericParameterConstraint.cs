namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
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
