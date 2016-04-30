namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedAbstractClasses
{
    public struct StructWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
