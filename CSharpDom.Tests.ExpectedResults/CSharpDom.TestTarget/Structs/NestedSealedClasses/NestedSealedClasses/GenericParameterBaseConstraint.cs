namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedSealedClasses
{
    public struct StructWithNestedSealedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
