namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods
{
    public class ClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
