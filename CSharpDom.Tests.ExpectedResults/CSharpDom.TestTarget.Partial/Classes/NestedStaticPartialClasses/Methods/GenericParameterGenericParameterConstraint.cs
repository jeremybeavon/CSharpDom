namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public static Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
