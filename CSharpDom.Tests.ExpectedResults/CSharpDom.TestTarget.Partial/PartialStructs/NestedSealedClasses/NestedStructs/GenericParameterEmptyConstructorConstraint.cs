namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
