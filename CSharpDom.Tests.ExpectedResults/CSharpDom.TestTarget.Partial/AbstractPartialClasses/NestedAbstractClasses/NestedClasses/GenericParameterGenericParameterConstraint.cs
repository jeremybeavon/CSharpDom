namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
