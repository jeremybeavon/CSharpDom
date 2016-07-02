namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
