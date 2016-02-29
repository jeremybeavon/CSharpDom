using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasTypeDefinition
    {
        TypeDefinition TypeDefinition { get; }
    }
}
