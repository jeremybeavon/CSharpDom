namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStaticClasses
{
    public class ClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
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
