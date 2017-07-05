namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
