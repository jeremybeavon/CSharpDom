namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
