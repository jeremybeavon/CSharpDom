namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
