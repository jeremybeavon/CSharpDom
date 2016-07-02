namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStructs
{
    public class ClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
