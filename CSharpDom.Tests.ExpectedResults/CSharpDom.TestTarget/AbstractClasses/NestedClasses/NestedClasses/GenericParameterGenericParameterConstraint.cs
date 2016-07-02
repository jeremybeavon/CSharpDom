namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
