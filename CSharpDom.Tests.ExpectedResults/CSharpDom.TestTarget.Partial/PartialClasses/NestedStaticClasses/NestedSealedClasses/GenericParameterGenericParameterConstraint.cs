namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
