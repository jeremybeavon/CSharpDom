namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
