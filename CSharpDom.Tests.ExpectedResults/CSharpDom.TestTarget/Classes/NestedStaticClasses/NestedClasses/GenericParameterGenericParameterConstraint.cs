namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedClasses
{
    public class ClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
