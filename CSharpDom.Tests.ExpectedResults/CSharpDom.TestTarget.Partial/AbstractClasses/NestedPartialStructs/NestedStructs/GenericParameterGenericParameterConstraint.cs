namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStructs
{
    public abstract class AbstractClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
