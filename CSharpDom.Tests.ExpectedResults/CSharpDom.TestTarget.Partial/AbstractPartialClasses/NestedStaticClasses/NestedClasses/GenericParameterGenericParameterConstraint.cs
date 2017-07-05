namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
