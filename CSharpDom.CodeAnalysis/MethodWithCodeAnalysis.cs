using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class MethodWithCodeAnalysis :
        EditableMethod<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object method;
        private readonly Node<MethodWithCodeAnalysis, MethodDeclarationSyntax> node;
        private readonly AttributeListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax> attributes;
        private readonly GenericParameterDeclarationListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax> genericParameters;
        private readonly SeparatedSyntaxListWrapper<
            MethodWithCodeAnalysis,
            MethodDeclarationSyntax,
            MethodParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedChildNode<
            MethodWithCodeAnalysis,
            MethodDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> returnType;

        internal MethodWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, AbstractMethodWithCodeAnalysis method)
            : this(method)
        {
            AbstractClassParent = parent;
        }

        internal MethodWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassMethodWithCodeAnalysis method, ClassType classType)
            : this(method)
        {
            SetClassParent(parent, classType);
        }

        internal MethodWithCodeAnalysis(
            ClassTypeWithCodeAnalysis parent,
            ExplicitInterfaceMethodWithCodeAnalysis method)
            : this(method)
        {
            ExplicitInterfaceClassParent = parent;
        }

        internal MethodWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassMethodWithCodeAnalysis method)
            : this(method)
        {
            SealedClassParent = parent;
        }

        internal MethodWithCodeAnalysis(InterfaceTypeWithCodeAnalysis parent, InterfaceMethodWithCodeAnalysis method)
            : this(method)
        {
            InterfaceParent = parent;
        }

        private MethodWithCodeAnalysis(object method)
        {
            node = new Node<MethodWithCodeAnalysis, MethodDeclarationSyntax>(this);
            this.method = method;
            attributes = new AttributeListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.MethodParent = parent);
            genericParameters = new GenericParameterDeclarationListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameterList,
                (parentSyntax, childSyntax) => parentSyntax.WithTypeParameterList(childSyntax),
                syntax => syntax.ConstraintClauses,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraintClauses(childSyntax),
                parent => new GenericParameterDeclarationWithCodeAnalysis(parent),
                (child, parent) => child.MethodParent = parent);
            parameters = new SeparatedSyntaxListWrapper<MethodWithCodeAnalysis, MethodDeclarationSyntax, MethodParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                parent => new MethodParameterWithCodeAnalysis(parent),
                (child, parent) => child.Parameter.MethodParent = parent);
            returnType = new CachedChildNode<MethodWithCodeAnalysis, MethodDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                parent => parent.Syntax.ReturnType.ToTypeReference(),
                (parentSyntax, childSyntax) => parentSyntax.WithReturnType(childSyntax),
                null);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Attributes; }
            set { attributes.Attributes = value; }
        }

        public override IBasicType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { genericParameters.ReplaceList(value); }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override IList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set
            {
                Syntax = Syntax.WithParameterList(
                    SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return attributes.TargetedAttributes; }
            set { attributes.TargetedAttributes = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType.Value; }
            set { returnType.Value = value; }
        }

        public MethodDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IGenericParameterCollection GenericParameterList
        {
            get { return genericParameters; }
        }

        internal IChildCollection<MethodParameterWithCodeAnalysis, ParameterSyntax> ParameterList
        {
            get { return parameters; }
        }

        internal Node<MethodWithCodeAnalysis, MethodDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal ClassTypeWithCodeAnalysis AbstractClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.AbstractType.Methods.AbstractMethodList);
            }
        }

        internal ClassTypeWithCodeAnalysis ExplicitInterfaceClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Methods.ExplicitInterfaceMethodList);
            }
        }

        internal InterfaceTypeWithCodeAnalysis InterfaceParent
        {
            get { return node.GetParentNode<InterfaceTypeWithCodeAnalysis>(); }
            set { node.SetParentNode<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(value, parent => parent.MethodList); }
        }

        internal ClassTypeWithCodeAnalysis SealedClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.SealedType.Methods.MethodList);
            }
        }

        internal void SetClassParent(ClassTypeWithCodeAnalysis value, ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Normal:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Methods.MethodList);
                    break;
                case ClassType.Abstract:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.AbstractType.Methods.MethodList);
                    break;
            }
        }
        
        T ISimpleMember.Member<T>()
        {
            return (T)method;
        }
    }
}
