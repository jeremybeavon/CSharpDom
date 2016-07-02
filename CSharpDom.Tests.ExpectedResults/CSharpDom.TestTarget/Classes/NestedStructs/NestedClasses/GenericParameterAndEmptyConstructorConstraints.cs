namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
