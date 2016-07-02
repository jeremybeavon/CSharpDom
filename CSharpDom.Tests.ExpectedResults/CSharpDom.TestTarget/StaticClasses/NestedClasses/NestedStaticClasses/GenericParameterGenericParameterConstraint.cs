namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
