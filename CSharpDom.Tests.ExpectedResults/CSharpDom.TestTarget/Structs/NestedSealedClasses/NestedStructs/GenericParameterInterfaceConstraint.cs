namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs
{
    public struct StructWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
