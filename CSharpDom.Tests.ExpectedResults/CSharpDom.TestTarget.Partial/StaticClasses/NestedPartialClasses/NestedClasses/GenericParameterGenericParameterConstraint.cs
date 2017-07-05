namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
