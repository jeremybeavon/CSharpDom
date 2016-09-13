using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class MethodWithBodyWithCodeAnalysis :
        EditableMethod<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>
    {
        private readonly MethodWithCodeAnalysis method;
        private readonly MethodBodyNode<MethodWithCodeAnalysis, MethodDeclarationSyntax> body;

        internal MethodWithBodyWithCodeAnalysis(
            ClassTypeWithCodeAnalysis parent,
            ClassMethodWithCodeAnalysis method,
            ClassType classType)
            : this(new MethodWithCodeAnalysis(parent, method, classType))
        {
        }

        internal MethodWithBodyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ExplicitInterfaceMethodWithCodeAnalysis method)
            : this(new MethodWithCodeAnalysis(parent, method))
        {
        }

        internal MethodWithBodyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassMethodWithCodeAnalysis method)
            : this(new MethodWithCodeAnalysis(parent, method))
        {
        }

        internal MethodWithBodyWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, ExtensionMethodWithCodeAnalysis method)
            : this(new MethodWithCodeAnalysis(parent, method))
        {
        }

        internal MethodWithBodyWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassMethodWithCodeAnalysis method)
            : this(new MethodWithCodeAnalysis(parent, method))
        {
        }

        internal MethodWithBodyWithCodeAnalysis(StructTypeWithCodeAnalysis parent, ExplicitInterfaceMethodWithCodeAnalysis method)
            : this(new MethodWithCodeAnalysis(parent, method))
        {
        }

        internal MethodWithBodyWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructMethodWithCodeAnalysis method)
            : this(new MethodWithCodeAnalysis(parent, method))
        {
        }

        private MethodWithBodyWithCodeAnalysis(MethodWithCodeAnalysis method)
        {
            this.method = method;
            body = new MethodBodyNode<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                method.Node,
                syntax => syntax.Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
        }

        public MethodWithCodeAnalysis Method
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
            get { return body.Value; }
            set { body.Value = value; }
        }

        public override IType DeclaringType
        {
            get { return Node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
            set { method.GenericParameters = value; }
        }

        public override bool IsAsync
        {
            get { return Syntax.Modifiers.Any(SyntaxKind.AsyncKeyword); }
            set
            {
                if (value != IsAsync)
                {
                    MethodDeclarationSyntax syntax = Syntax;
                    if (value)
                    {
                        Syntax = syntax.WithModifiers(syntax.Modifiers.Add(SyntaxKind.AsyncKeyword));
                    }
                    else
                    {
                        Syntax = syntax.WithModifiers(syntax.Modifiers.Remove(SyntaxKind.AsyncKeyword));
                    }
                }
            }
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

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
            set { method.ReturnType = value; }
        }

        public MethodDeclarationSyntax Syntax
        {
            get { return method.Syntax; }
            set { method.Syntax = value; }
        }

        internal Node<MethodWithCodeAnalysis, MethodDeclarationSyntax> Node
        {
            get { return method.Node; }
        }
    }
}
