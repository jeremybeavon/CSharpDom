using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassMethodWithCodeAnalysis :
        AbstractClassMethod<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>
    {
        private readonly MethodWithCodeAnalysis method;
        private readonly IInternalTypeWithCodeAnalysis declaringType;

        internal ClassMethodWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.method = new MethodWithCodeAnalysis(declaringType, method);
            this.declaringType = declaringType;
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

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return method.MethodDefinition.InheritanceModifier(declaringType); }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return method.MethodDefinition.ClassVisibility(); }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
        }
    }
}
