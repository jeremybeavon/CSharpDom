using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterDeclarationWithCodeAnalysis :
        EditableGenericParameterDeclaration<
            ClassReferenceWithCodeAnalysis,
            GenericParameterReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis>,
        IHasSyntax<GenericParameterDeclarationSyntax>,
        IHasNode<GenericParameterDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private Guid internalId;
        private readonly Node<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax> node;
        private readonly AttributeListWrapper<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            GenericParameterDeclarationWithCodeAnalysis,
            GenericParameterDeclarationSyntax,
            ClassReferenceWithCodeAnalysis,
            NameSyntax> baseClassConstraint;
        private readonly SeparatedSyntaxListWrapper<
            GenericParameterDeclarationWithCodeAnalysis,
            GenericParameterDeclarationSyntax,
            IInternalTypeReferenceWithCodeAnalysis,
            TypeSyntax> constraints;
        private readonly FilteredList<ITypeReferenceWithCodeAnalysis, GenericParameterReferenceWithCodeAnalysis> genericParameterConstraints;
        private readonly IList<InterfaceReferenceWithCodeAnalysis> interfaceConstraints;

        internal GenericParameterDeclarationWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameter.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            //baseClass = new CachedChildNode<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax, ClassReferenceWithCodeAnalysis>(
            //    node,
            //    parent => new ClassReferenceWithCodeAnalysis(parent)
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override ClassReferenceWithCodeAnalysis BaseClassConstraint
        {
            get { return baseClassConstraint.Value; }
            set { baseClassConstraint.Value = value; }
        }

        public override ICollection<GenericParameterReferenceWithCodeAnalysis> GenericParameterConstraints
        {
            get { return genericParameterConstraints; }
            set { }
        }

        public override bool HasEmptyConstructorConstraint
        {
            get { return Syntax.Constraints.OfType<ConstructorConstraintSyntax>().Any(); }
            set
            {
                if (value != HasEmptyConstructorConstraint)
                {
                    GenericParameterDeclarationSyntax syntax = Syntax;
                    SeparatedSyntaxList<TypeParameterConstraintSyntax> constraints = syntax.Constraints;
                    if (value)
                    {
                        Syntax = syntax.WithConstraints(constraints.Add(SyntaxFactory.ConstructorConstraint()));
                    }
                    else
                    {
                        Syntax = syntax.WithConstraints(constraints.RemoveAt(constraints.Count - 1));
                    }
                }
            }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> InterfaceConstraints
        {
            get { return interfaceConstraints; }
            set { }
        }

        public override string Name
        {
            get { return Syntax.TypeParameter.Identifier.Text; }
            set { Syntax = Syntax.WithName(value); }
        }
        
        public override GenericParameterTypeConstraint TypeConstraint
        {
            get
            {
                return Syntax.Constraints
                    .OfType<ClassOrStructConstraintSyntax>()
                    .Select(ToTypeConstraint)
                    .FirstOrDefault() ?? GenericParameterTypeConstraint.None;
            }
            set
            {
                if (value != TypeConstraint)
                {
                    GenericParameterDeclarationSyntax syntax = Syntax;
                    SyntaxKind kind = SyntaxKind.ClassKeyword;
                    switch (value)
                    {
                        case GenericParameterTypeConstraint.None:
                            Syntax = syntax.WithConstraints(syntax.Constraints.RemoveAt(0));
                            return;
                        case GenericParameterTypeConstraint.Struct:
                            kind = SyntaxKind.StructKeyword;
                            break;
                    }

                    Syntax = syntax.WithConstraints(syntax.Constraints.Insert(0, SyntaxFactory.ClassOrStructConstraint(kind)));
                }
            }
        }

        public override GenericParameterDeclarationDirection Direction
        {
            get
            {
                switch (Syntax.TypeParameter.VarianceKeyword.Kind())
                {
                    case SyntaxKind.InKeyword:
                        return GenericParameterDeclarationDirection.In;
                    case SyntaxKind.OutKeyword:
                        return GenericParameterDeclarationDirection.Out;
                    default:
                        return GenericParameterDeclarationDirection.None;
                }
            }
            set
            {
                if (value != Direction)
                {
                    switch (value)
                    {
                        case GenericParameterDeclarationDirection.None:
                            Syntax = Syntax.WithVariance(SyntaxKind.None);
                            break;
                        case GenericParameterDeclarationDirection.In:
                            Syntax = Syntax.WithVariance(SyntaxKind.InKeyword);
                            break;
                        case GenericParameterDeclarationDirection.Out:
                            Syntax = Syntax.WithVariance(SyntaxKind.OutKeyword);
                            break;
                    }
                }
            }
        }

        public GenericParameterDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<GenericParameterDeclarationSyntax> IHasNode<GenericParameterDeclarationSyntax>.Node
        {
            get { return node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterDeclarationWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        private static GenericParameterTypeConstraint? ToTypeConstraint(ClassOrStructConstraintSyntax syntax)
        {
            return syntax.ClassOrStructKeyword.Kind() == SyntaxKind.ClassKeyword ?
                GenericParameterTypeConstraint.Class :
                GenericParameterTypeConstraint.Struct;
        }
    }
}
