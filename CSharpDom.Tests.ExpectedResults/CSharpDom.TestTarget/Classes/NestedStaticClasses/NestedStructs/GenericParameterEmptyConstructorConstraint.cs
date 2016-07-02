namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStructs
{
    public class ClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
