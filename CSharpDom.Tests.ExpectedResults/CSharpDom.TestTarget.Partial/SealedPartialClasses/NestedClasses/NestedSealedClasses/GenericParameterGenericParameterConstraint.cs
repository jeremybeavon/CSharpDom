namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
