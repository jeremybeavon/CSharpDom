namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Methods
{
    public sealed class SealedClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint
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
