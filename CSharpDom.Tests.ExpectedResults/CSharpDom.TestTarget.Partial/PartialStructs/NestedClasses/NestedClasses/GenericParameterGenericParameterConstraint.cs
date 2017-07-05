namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
