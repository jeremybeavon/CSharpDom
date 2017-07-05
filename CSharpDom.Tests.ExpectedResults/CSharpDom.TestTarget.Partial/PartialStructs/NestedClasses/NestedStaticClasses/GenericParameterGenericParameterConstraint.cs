namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
