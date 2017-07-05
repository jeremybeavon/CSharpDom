namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
