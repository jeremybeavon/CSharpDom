namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStructs
{
    public partial struct PartialStructWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
