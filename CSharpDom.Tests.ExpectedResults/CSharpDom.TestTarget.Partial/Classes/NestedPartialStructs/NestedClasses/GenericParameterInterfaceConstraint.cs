namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
