namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
