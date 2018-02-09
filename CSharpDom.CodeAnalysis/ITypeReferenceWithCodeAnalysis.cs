using CSharpDom.Common;
using CSharpDom.Common.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface ITypeReferenceWithCodeAnalysis : IEditableTypeReference, IHasSyntax<TypeSyntax>, IHasName
    {
    }
}
