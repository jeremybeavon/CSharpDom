namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods
{
    public partial class PartialClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
