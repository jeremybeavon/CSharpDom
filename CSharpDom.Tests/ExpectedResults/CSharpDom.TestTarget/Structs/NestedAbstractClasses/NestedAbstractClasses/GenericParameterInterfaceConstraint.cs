namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
