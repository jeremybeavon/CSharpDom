namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint
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
