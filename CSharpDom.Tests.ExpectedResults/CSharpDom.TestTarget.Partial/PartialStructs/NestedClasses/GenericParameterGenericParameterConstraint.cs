namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
