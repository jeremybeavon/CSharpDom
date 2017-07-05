namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct<T>
            where T : class
        {
        }
    }
}
