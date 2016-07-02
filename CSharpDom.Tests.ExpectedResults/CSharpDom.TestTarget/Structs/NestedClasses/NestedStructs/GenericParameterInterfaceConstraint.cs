namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStructs
{
    public struct StructWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
