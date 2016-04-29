namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStructs
{
    public class ClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
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
