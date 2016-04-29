namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs
{
    public class ClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
