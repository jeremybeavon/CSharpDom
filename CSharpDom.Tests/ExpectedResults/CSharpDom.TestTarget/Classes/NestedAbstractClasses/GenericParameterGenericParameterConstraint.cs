namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
