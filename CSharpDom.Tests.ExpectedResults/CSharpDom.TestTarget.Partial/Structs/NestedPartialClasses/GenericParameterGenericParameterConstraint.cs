namespace CSharpDom.TestTarget.Partial.Structs.NestedClasses
{
    public struct StructWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
