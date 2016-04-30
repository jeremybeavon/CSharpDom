namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
