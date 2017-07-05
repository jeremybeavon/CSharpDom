namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
