namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
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
