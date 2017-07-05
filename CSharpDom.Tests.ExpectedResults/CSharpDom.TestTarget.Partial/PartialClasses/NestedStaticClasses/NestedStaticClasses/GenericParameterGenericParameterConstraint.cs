namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
