namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
