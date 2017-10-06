using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedDelegateWithCodeAnalysis :
        EditableNestedDelegate<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasSyntax<DelegateDeclarationSyntax>
    {
        private readonly DelegateTypeWithCodeAnalysis type;
        
        internal NestedDelegateWithCodeAnalysis()
        {
            type = new DelegateTypeWithCodeAnalysis();
        }

        public DelegateTypeWithCodeAnalysis Delegate
        {
            get { return type; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return type.Attributes; }
            set { type.Attributes = value; }
        }

        public override IType DeclaringType
        {
            get { return type.Node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return type.GenericParameters; }
            set { type.GenericParameters = value; }
        }

        public override string Name
        {
            get { return type.Name; }
            set { type.Name = value; }
        }

        public override IList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return type.Parameters; }
            set { type.Parameters = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return type.ReturnType; }
            set { type.ReturnType = value; }
        }

        public DelegateDeclarationSyntax Syntax
        {
            get { return type.Syntax; }
            set { type.Syntax = value; }
        }
    }
}
