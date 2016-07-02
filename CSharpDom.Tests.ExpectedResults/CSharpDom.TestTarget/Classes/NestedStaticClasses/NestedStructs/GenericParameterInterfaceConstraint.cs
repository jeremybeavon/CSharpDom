namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStructs
{
    public class ClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
