namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
