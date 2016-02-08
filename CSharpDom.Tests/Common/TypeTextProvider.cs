﻿using System;
using System.IO;
using System.Reflection;
using CSharpDom.Reflection;

namespace CSharpDom.Tests.Common
{
    public static class TypeTextProvider
    {
        public static string GetTypeText(Type type)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetResourceName(type)))
            {
                using (TextReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd().Trim();
                }
            }
        }

        private static string GetResourceName(Type type)
        {
            return "CSharpDom.Tests.ExpectedResults." + type.Namespace + "." + type.Name() + ".cs";
        }
    }
}
