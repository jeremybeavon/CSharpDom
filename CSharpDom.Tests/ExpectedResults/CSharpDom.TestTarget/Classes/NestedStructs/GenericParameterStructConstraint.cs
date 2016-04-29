namespace CSharpDom.TestTarget.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct<T>
            where T : struct
        {
        }
    }
}
