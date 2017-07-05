namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
