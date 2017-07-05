namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
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
