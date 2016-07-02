namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
