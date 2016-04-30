namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint
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
