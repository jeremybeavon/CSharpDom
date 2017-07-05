namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
