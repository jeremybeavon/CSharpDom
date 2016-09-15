using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal static class ArgumentSyntaxExtensions
    {
        public static IInternalArgument ToInternalArgument(this ArgumentSyntax syntax)
        {
            return null;
        }
    }
}
