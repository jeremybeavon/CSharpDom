using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfaceMethodWithCodeAnalysis :
        EditableExplicitInterfaceMethod<
            AttributeGroupWithCodeAnalysis,
            IType,
            InterfaceReferenceWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly MethodWithBodyWithCodeAnalysis method;
        private readonly CachedChildNode<
            MethodWithCodeAnalysis,
            MethodDeclarationSyntax,
            InterfaceReferenceWithCodeAnalysis,
            NameSyntax> explicitInterface;

        internal ExplicitInterfaceMethodWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            method = new MethodWithBodyWithCodeAnalysis(parent, this);
        }

        internal ExplicitInterfaceMethodWithCodeAnalysis(StructTypeWithCodeAnalysis parent)
            : this()
        {
            method = new MethodWithBodyWithCodeAnalysis(parent, this);
        }

        private ExplicitInterfaceMethodWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            explicitInterface = new CachedChildNode<MethodWithCodeAnalysis, MethodDeclarationSyntax, InterfaceReferenceWithCodeAnalysis, NameSyntax>(
                method.Node,
                (parentSyntax, childSyntax) => parentSyntax.WithExplicitInterfaceSpecifier(parentSyntax.ExplicitInterfaceSpecifier.WithName(childSyntax)),
                parent => new InterfaceReferenceWithCodeAnalysis(parent),
                (child, parent) => child.TypeReference.ExplicitInterfaceMethodParent = parent);
        }

        public MethodWithBodyWithCodeAnalysis Method
        {
            get { return method; }
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

        public override IType DeclaringType
        {
            get { return method.DeclaringType; }
            set { method.DeclaringType = value; }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface.Value; }
            set { explicitInterface.Value = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
            set { method.GenericParameters = value; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
            set { method.IsAsync = value; }
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

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
            set { method.ReturnType = value; }
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
