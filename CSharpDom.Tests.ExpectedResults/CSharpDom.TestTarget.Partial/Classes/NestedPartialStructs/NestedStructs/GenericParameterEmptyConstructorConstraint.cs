namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
