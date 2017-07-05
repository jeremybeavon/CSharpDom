namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
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
