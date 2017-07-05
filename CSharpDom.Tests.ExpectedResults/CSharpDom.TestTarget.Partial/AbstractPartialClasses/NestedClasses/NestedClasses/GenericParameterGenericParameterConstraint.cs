namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
