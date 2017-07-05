namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
