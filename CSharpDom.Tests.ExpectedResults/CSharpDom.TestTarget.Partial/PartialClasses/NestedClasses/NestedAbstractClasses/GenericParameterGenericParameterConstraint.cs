namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
