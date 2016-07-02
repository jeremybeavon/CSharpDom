namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStructs
{
    public struct StructWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
