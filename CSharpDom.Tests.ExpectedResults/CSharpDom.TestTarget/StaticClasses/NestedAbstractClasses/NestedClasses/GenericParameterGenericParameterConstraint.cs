namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
