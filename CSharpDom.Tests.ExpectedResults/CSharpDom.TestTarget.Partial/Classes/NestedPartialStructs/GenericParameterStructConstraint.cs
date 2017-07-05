namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterStructConstraint
    {
        public struct Struct<T>
            where T : struct
        {
        }
    }
}
