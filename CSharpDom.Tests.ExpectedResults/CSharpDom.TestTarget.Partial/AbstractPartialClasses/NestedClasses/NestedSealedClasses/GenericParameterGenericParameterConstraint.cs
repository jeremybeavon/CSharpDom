namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
