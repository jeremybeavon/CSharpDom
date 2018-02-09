using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        private static readonly Regex interfaceMatch = new Regex(@"^I[A-Z]", RegexOptions.Compiled);
        private static readonly Regex genericParameterMatch = new Regex("^T(?:[A-Z]|$)", RegexOptions.Compiled);
        private readonly Node<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax> node;
        private readonly AttributeListWrapper<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax> attributes;
        private readonly IList<ClassReferenceWithCodeAnalysis> baseClassConstraint;
        private readonly IList<GenericParameterReferenceWithCodeAnalysis> genericParameterConstraints;
        private readonly IList<InterfaceReferenceWithCodeAnalysis> interfaceConstraints;
        private readonly MemberList<
            GenericParameterDeclarationWithCodeAnalysis,
            GenericParameterDeclarationSyntax,
            TypeParameterConstraintSyntax> members;

        public GenericParameterDeclarationWithCodeAnalysis(string name)
            : this()
        {
            Syntax = new GenericParameterDeclarationSyntax(SyntaxFactory.TypeParameter(name), null);
        }

        internal GenericParameterDeclarationWithCodeAnalysis()
        {
            node = new Node<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax>(
                node,
                syntax => syntax.TypeParameter.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            baseClassConstraint = ListFactory.CreateConstraintList(
                node,
                name => !interfaceMatch.IsMatch(name) && !genericParameterMatch.IsMatch(name),
                type => new ClassReferenceWithCodeAnalysis(type));
            genericParameterConstraints = ListFactory.CreateConstraintList(
                node,
                name => genericParameterMatch.IsMatch(name),
                type => new GenericParameterReferenceWithCodeAnalysis(type));
            interfaceConstraints = ListFactory.CreateConstraintList(
                node,
                name => interfaceMatch.IsMatch(name),
                type => new InterfaceReferenceWithCodeAnalysis(type));
            members = new MemberList<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax, TypeParameterConstraintSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraints(SyntaxFactory.SeparatedList(childSyntax)))
            {
                { nameof(BaseClassConstraint), () => baseClassConstraint.Select(item => item.TypeReference.Node.GetParent<TypeParameterConstraintSyntax>()) },
                { nameof(GenericParameterConstraints), () => genericParameterConstraints.Select(item => item.TypeReference.Node.GetParent<TypeParameterConstraintSyntax>()) },
                { nameof(InterfaceConstraints), () => interfaceConstraints.Select(item => item.TypeReference.Node.GetParent<TypeParameterConstraintSyntax>()) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override ClassReferenceWithCodeAnalysis BaseClassConstraint
        {
            get { return baseClassConstraint.FirstOrDefault(); }
            set
            {
                TypeParameterConstraintSyntax[] parameters = new TypeParameterConstraintSyntax[]
                {
                    SyntaxFactory.TypeConstraint(value.Syntax)
                };
                members.CombineList(nameof(BaseClassConstraint), parameters);
            }
        }

        public override ICollection<GenericParameterReferenceWithCodeAnalysis> GenericParameterConstraints
        {
            get { return genericParameterConstraints; }
            set
            {
                members.CombineList(
                    nameof(GenericParameterConstraints),
                    value.Select(constraint => SyntaxFactory.TypeConstraint(constraint.Syntax)));
            }
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
            set
            {
                members.CombineList(
                    nameof(InterfaceConstraints),
                    value.Select(constraint => SyntaxFactory.TypeConstraint(constraint.Syntax)));
            }
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
                    .FirstOrDefault() ?? CSharpDom.GenericParameterTypeConstraint.None;
            }
            set
            {
                if (value != TypeConstraint)
                {
                    GenericParameterDeclarationSyntax syntax = Syntax;
                    SyntaxKind kind = SyntaxKind.ClassKeyword;
                    switch (value)
                    {
                        case CSharpDom.GenericParameterTypeConstraint.None:
                            Syntax = syntax.WithConstraints(syntax.Constraints.RemoveAt(0));
                            return;
                        case CSharpDom.GenericParameterTypeConstraint.Struct:
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
