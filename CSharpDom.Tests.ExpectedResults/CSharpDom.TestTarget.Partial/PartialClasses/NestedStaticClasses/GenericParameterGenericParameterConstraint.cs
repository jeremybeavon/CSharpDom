namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
