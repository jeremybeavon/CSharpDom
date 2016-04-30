namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Constructors
{
    public abstract class AbstractClassWithNestedClassWithConstructorWithParametersWithModifiers
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
