namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Methods
{
    public sealed partial class SealedPartialClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint
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
