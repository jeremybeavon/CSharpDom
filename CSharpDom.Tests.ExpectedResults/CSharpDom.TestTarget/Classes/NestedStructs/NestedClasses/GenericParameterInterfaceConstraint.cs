namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint
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
