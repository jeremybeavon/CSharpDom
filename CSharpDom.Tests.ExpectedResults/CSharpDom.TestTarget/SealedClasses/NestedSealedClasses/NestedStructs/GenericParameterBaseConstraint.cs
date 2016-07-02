namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
