namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint
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
