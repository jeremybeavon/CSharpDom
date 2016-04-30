namespace CSharpDom.TestTarget.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
