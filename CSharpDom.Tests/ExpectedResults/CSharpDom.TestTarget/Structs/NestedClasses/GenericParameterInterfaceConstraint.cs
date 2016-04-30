namespace CSharpDom.TestTarget.Structs.NestedClasses
{
    public struct StructWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
