using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasTypeReference
    {
        TypeReference TypeReference { get; }
    }
}
