using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class LoadedDocumentWithCodeAnalysis :
        EditableLoadedDocument<
            ISolution,
            IProject,
            IDocument,
            IUsingDirective,
            AttributeGroupWithCodeAnalysis,
            INamespace,
            >
    {
    }
}
