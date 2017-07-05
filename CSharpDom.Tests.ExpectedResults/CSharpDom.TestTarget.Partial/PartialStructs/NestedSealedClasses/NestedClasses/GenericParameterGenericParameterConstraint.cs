namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint
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
