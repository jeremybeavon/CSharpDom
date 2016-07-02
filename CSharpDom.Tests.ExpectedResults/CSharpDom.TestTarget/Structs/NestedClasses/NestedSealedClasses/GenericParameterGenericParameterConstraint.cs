namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedSealedClasses
{
    public struct StructWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
