namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
