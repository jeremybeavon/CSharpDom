namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStructs
{
    public class ClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
