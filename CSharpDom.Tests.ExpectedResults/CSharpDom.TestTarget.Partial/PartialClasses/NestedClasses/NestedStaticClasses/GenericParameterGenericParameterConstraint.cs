namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
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
