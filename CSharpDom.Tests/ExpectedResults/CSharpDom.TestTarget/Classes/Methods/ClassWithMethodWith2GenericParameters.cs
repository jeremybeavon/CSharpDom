namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWith2GenericParameters
    {
        public Dictionary<TKey, TValue> Method<TKey, TValue>()
        {
            return default(Dictionary<TKey, TValue>);
        }
    }
}
