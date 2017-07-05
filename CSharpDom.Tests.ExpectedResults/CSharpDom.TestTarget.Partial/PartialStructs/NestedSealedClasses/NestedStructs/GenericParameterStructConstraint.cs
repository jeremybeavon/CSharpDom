namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
