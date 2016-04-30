namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
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
