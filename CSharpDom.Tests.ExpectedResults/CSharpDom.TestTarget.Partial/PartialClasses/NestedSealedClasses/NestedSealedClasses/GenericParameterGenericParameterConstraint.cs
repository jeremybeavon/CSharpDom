namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
