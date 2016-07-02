namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Methods
{
    public class ClassWithNestedStaticClassWithMethodWith2GenericParameters
    {
        public static class Class
        {
            public static Dictionary<TKey, TValue> Method<TKey, TValue>()
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
