namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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
