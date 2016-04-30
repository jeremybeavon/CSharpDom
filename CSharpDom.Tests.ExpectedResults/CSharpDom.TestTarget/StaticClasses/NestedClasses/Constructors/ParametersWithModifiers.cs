﻿namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Constructors
{
    public static class StaticClassWithNestedClassWithConstructorWithParametersWithModifiers
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
