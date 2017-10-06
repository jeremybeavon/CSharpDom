using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class TypeReferenceWithCodeAnalysis :
        EditableTypeReference,
        IHasSyntax<TypeSyntax>
    {
        
        public TypeSyntax Syntax
        {
            get { return null; }
            set { }
        }
    }
}
