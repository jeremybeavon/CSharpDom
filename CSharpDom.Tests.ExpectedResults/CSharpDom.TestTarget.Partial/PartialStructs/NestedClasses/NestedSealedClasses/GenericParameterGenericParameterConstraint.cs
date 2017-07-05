namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
