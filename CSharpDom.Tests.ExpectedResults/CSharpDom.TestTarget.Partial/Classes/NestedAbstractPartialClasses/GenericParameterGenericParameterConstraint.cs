namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
