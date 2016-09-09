using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
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
        
        internal NestedDelegateWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassNestedDelegateWithCodeAnalysis @delegate)
        {
            type = new DelegateTypeWithCodeAnalysis(parent, @delegate);
        }

        internal NestedDelegateWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassNestedDelegateWithCodeAnalysis @delegate)
        {
            type = new DelegateTypeWithCodeAnalysis(parent, @delegate);
        }

        internal NestedDelegateWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructNestedDelegateWithCodeAnalysis @delegate)
        {
            type = new DelegateTypeWithCodeAnalysis(parent, @delegate);
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
