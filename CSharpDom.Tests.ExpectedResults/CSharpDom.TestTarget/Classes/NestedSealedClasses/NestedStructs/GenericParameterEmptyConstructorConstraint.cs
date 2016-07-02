namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs
{
    public class ClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
