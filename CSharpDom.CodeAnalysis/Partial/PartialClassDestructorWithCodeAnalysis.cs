﻿using CSharpDom.BaseClasses.Editable;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassDestructorWithCodeAnalysis :
        EditableDestructor<AttributeGroupWithCodeAnalysis, IPartialClassTypeWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<DestructorDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassDestructorWithCodeAnalysis destructor;

        public PartialClassDestructorWithCodeAnalysis(
            string name,
            MethodBodyWithCodeAnalysis body)
            : this(new ClassDestructorWithCodeAnalysis(name, body))
        {
        }

        internal PartialClassDestructorWithCodeAnalysis(ClassDestructorWithCodeAnalysis destructor)
        {
            this.destructor = destructor;
            destructor.DeclaringTypeFunc = () => DeclaringType.Class;
        }

        public ClassDestructorWithCodeAnalysis Destructor
        {
            get { return destructor; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return destructor.Attributes; }
            set { destructor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return destructor.Body; }
            set { destructor.Body = value; }
        }

        public override IPartialClassTypeWithCodeAnalysis DeclaringType
        {
            get { return destructor.Destructor.Node.GetParent<IPartialClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }
        
        public DestructorDeclarationSyntax Syntax
        {
            get { return destructor.Syntax; }
            set { destructor.Syntax = value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
