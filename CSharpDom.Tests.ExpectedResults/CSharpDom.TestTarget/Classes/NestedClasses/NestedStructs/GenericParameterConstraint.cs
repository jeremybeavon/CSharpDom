namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStructs
{
    public class ClassWithNestedClassWithNestedStructWithGenericParameterClassConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
