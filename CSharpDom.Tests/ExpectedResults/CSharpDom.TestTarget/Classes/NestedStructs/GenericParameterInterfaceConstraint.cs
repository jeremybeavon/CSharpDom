namespace CSharpDom.TestTarget.Classes.NestedStructs
{
    public class ClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public struct Struct<T>
            where T : IInterface
        {
        }
    }
}
