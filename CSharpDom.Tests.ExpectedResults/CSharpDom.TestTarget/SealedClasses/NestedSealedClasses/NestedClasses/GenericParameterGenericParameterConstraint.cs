namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
