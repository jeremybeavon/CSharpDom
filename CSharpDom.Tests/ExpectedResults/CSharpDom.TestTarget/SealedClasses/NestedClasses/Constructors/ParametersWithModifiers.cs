namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Constructors
{
    public sealed class SealedClassWithNestedClassWithConstructorWithParametersWithModifiers
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
