namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStaticClasses
{
    public class ClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
