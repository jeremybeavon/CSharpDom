namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
