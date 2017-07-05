namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
