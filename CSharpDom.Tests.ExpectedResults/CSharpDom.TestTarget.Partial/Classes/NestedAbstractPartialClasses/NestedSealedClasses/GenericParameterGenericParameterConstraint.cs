namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
