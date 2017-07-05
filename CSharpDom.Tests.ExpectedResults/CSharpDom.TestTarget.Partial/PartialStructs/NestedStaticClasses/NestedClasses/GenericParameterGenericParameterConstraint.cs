namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
