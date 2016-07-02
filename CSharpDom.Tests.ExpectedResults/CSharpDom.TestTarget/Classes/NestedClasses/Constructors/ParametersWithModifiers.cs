namespace CSharpDom.TestTarget.Classes.NestedClasses.Constructors
{
    public class ClassWithNestedClassWithConstructorWithParametersWithModifiers
    {
        public class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
