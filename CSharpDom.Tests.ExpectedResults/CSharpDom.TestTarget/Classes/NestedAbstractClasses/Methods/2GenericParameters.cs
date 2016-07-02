namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods
{
    public class ClassWithNestedAbstractClassWithMethodWith2GenericParameters
    {
        public abstract class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
