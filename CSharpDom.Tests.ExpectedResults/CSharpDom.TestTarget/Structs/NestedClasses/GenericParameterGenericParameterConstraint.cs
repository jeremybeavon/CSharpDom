namespace CSharpDom.TestTarget.Structs.NestedClasses
{
    public struct StructWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
