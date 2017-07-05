namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
