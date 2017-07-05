namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
