namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
