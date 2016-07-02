namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStructs
{
    public static class StaticClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
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
