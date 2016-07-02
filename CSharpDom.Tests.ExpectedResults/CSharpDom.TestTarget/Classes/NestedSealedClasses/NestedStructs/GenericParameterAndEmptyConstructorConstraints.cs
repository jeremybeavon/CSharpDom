namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs
{
    public class ClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
