namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct<T>
            where T : BaseClass
        {
        }
    }
}
