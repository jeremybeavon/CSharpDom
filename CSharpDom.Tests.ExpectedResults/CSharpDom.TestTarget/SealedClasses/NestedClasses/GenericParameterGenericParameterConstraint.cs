namespace CSharpDom.TestTarget.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
