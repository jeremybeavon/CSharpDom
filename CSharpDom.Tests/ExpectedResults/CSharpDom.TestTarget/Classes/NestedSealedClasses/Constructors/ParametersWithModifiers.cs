namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors
{
    public class ClassWithNestedSealedClassWithConstructorWithParametersWithModifiers
    {
        public sealed class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
