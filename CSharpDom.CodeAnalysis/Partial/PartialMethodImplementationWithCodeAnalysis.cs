using CSharpDom.Common;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialMethodImplementationWithCodeAnalysis :
        EditablePartialMethodImplementation<
            AttributeGroupWithCodeAnalysis,
            IClassType,
            GenericParameterDeclarationWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>,
        IHasNode<MethodDeclarationSyntax>
    {
        private readonly MethodWithBodyWithCodeAnalysis method;
        
        internal PartialMethodImplementationWithCodeAnalysis()
        {
            method = new MethodWithBodyWithCodeAnalysis();
        }
        
        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return method.Attributes; }
            set { method.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return method.Body; }
            set { method.Body = value; }
        }

        public override IClassType DeclaringType
        {
            get { return method.Method.Node.GetParentNode<IClassType>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
            set { method.GenericParameters = value; }
        }
        
        public override string Name
        {
            get { return method.Name; }
            set { method.Name = value; }
        }

        public override IList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return method.Parameters; }
            set { method.Parameters = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
            set { method.ReturnAttributes = value; }
        }
        
        public MethodDeclarationSyntax Syntax
        {
            get { return method.Syntax; }
            set { method.Syntax = value; }
        }

        INode<MethodDeclarationSyntax> IHasNode<MethodDeclarationSyntax>.Node => method.Method.Node;
    }
}
