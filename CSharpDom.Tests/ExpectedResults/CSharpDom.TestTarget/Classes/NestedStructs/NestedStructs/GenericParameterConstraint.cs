namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
