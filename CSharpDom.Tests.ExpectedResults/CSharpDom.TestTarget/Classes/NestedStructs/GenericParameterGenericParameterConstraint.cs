namespace CSharpDom.TestTarget.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
