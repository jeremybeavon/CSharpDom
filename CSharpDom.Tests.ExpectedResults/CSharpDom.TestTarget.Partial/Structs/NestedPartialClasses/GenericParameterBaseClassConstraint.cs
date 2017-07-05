namespace CSharpDom.TestTarget.Partial.Structs.NestedClasses
{
    public struct StructWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
