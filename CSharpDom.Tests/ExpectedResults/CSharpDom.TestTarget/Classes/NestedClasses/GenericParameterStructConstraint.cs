namespace CSharpDom.TestTarget.Classes.NestedClasses
{
    public class ClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
