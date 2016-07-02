namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint
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
