namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : BaseClass
            {
            }
        }
    }
}
