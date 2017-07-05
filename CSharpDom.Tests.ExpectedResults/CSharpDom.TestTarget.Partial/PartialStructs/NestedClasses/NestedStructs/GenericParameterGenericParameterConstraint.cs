namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
