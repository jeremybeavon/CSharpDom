using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasTypeReference
    {
        TypeReference TypeReference { get; }
    }
}
