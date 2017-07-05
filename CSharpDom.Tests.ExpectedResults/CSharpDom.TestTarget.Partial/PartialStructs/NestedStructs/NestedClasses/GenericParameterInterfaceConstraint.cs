namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint
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
