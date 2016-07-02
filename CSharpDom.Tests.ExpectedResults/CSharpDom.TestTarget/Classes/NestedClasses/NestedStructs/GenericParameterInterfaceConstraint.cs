namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStructs
{
    public class ClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
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
