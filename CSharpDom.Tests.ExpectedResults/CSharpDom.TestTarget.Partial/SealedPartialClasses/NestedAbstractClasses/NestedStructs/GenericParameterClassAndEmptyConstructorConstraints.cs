namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
