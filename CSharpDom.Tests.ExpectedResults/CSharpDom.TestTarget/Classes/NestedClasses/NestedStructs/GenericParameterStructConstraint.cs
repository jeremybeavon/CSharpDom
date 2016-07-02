namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedStructs
{
    public class ClassWithNestedClassWithNestedStructWithGenericParameterStructConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
