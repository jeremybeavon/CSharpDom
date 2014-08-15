using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IClass : IHasName, ICanBeGeneric
    {
    }
}
