using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructMethodWithCodeAnalysis :
        AbstractStructMethod<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>
    {
        private readonly MethodWithCodeAnalysis method;

        internal StructMethodWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.method = new MethodWithCodeAnalysis(declaringType, method);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return method.Attributes; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return method.Body; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get { return method.MethodDefinition.IsStatic ? StructMemberInheritanceModifier.Static : StructMemberInheritanceModifier.None; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return method.Parameters; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return method.MethodDefinition.StructVisibility(); }
        }
    }
}
