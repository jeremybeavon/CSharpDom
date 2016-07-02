namespace CSharpDom.TestTarget.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
