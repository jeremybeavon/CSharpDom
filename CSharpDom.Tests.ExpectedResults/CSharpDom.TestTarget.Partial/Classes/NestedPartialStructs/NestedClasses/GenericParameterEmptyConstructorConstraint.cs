namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
