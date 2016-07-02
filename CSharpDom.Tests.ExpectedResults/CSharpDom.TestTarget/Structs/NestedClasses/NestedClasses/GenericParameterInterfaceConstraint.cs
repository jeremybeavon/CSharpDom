namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses
{
    public struct StructWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
