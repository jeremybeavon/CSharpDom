using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassReferenceWithCodeAnalysis :
        EditableClassReference<GenericParameterWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<NameSyntax>
        //IVisitable<IReflectionVisitor>
    {
        private readonly Func<NameSyntax> getReference;
        private readonly Action<NameSyntax> setReference;
        private SeparatedSyntaxListWrapper<GenericParameterWithCodeAnalysis, TypeSyntax, ClassReferenceWithCodeAnalysis> genericParameters;

        //public ClassReferenceWithCodeAnalysis(string name)
        //    : this(new DetachedParent<NameSyntax>(SyntaxFactory.IdentifierName(name)))
        //{
        //}

        internal ClassReferenceWithCodeAnalysis(AttributeWithCodeAnalysis parent)
        {
            ParentAttribute = parent;
            getReference = () => ParentAttribute.Syntax.Name;
            setReference = syntax => ParentAttribute.Syntax = parent.Syntax.WithName(syntax);
            genericParameters = new SeparatedSyntaxListWrapper<GenericParameterWithCodeAnalysis, TypeSyntax, ClassReferenceWithCodeAnalysis>(
                () => getReference().GetGenericParameters(),
                list => setReference(getReference().SetGenericParameters(list)),
                () => new GenericParameterWithCodeAnalysis(this),
                this,
                (child, newParent) => child.ClassReferenceParent = newParent);
        }
    
        public NameSyntax Syntax
        {
            get { return getReference(); }
        }

        public override string Name
        {
            get { return getReference().ToName(); }
            set { setReference(SyntaxFactory.IdentifierName(value)); }
        }

        public override IList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set
            {
                setReference(getReference().SetGenericParameters(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        internal AttributeWithCodeAnalysis ParentAttribute { get; set; }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitClassReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
