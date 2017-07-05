namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
