using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassMethodWithMonoCecil :
        AbstractSealedClassMethod<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            MethodParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>
    {
        private readonly MethodWithMonoCecil method;
        private readonly IInternalTypeWithMonoCecil declaringType;

        internal SealedClassMethodWithMonoCecil(IInternalTypeWithMonoCecil declaringType, MethodInfo method)
        {
            this.method = new MethodWithMonoCecil(declaringType, method);
            this.declaringType = declaringType; 
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return method.Attributes; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return method.Body; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return method.GenericParameters; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return method.MethodInfo.SealedClassInheritanceModifier(declaringType); }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithMonoCecil> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return method.ReturnType; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return method.MethodInfo.ClassVisibility(); }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }
    }
}
