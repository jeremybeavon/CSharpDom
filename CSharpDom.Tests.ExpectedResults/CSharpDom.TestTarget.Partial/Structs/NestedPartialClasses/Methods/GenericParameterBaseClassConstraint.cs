namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
