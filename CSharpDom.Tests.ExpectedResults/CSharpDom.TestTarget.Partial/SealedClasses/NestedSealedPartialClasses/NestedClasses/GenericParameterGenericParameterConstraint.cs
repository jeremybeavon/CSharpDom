namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
