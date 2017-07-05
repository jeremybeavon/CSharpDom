namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
