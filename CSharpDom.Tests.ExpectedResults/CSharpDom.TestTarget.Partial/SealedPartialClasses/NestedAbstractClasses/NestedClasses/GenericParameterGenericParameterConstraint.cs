namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
