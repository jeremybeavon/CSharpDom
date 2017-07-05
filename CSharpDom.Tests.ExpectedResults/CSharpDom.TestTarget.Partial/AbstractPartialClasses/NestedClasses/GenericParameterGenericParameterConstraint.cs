namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
