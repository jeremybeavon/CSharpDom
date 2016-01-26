using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection
{
    public static class FieldInfoExtensions
    {
        public static bool IsVolatile(this FieldInfo field)
        {
            return field.GetRequiredCustomModifiers().Contains(typeof(IsVolatile));
        }
    }
}
