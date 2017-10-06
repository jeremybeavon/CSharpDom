using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructNestedDelegateWithCodeAnalysis :
        EditableStructNestedDelegate<
            AttributeGroupWithCodeAnalysis,
            IPartialStructTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasSyntax<DelegateDeclarationSyntax>
    {
        private readonly StructNestedDelegateWithCodeAnalysis nestedDelegate;

        public PartialStructNestedDelegateWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis returnType,
            string name,
            IEnumerable<DelegateParameterWithCodeAnalysis> parameters)
            : this(new StructNestedDelegateWithCodeAnalysis(visibility, returnType, name, parameters))
        {
        }

        internal PartialStructNestedDelegateWithCodeAnalysis(StructNestedDelegateWithCodeAnalysis nestedDelegate)
        {
            this.nestedDelegate = nestedDelegate;
            nestedDelegate.DeclaringTypeFunc = () => DeclaringType.Struct;
        }
        
        public StructNestedDelegateWithCodeAnalysis Delegate
        {
            get { return nestedDelegate; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedDelegate.Attributes; }
            set { nestedDelegate.Attributes = value; }
        }

        public override IPartialStructTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedDelegate.Delegate.Delegate.Node.GetParentNode<IPartialStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedDelegate.GenericParameters; }
            set { nestedDelegate.GenericParameters = value; }
        }

        public override string Name
        {
            get { return nestedDelegate.Name; }
            set { nestedDelegate.Name = value; }
        }

        public override IList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return nestedDelegate.Parameters; }
            set { nestedDelegate.Parameters = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return nestedDelegate.ReturnType; }
            set { nestedDelegate.ReturnType = value; }
        }

        public DelegateDeclarationSyntax Syntax
        {
            get { return nestedDelegate.Syntax; }
            set { nestedDelegate.Syntax = value; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.Visibility; }
            set { nestedDelegate.Visibility = value; }
        }
    }
}
