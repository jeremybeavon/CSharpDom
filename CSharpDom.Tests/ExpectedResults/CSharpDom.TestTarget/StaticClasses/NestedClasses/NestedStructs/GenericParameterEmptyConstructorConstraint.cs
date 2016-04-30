namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStructs
{
    public static class StaticClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
