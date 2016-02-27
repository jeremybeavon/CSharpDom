using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractMethodWithMonoCecil :
        AbstractAbstractMethod<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            MethodParameterWithMonoCecil>
    {
        private readonly MethodWithMonoCecil method;

        internal AbstractMethodWithMonoCecil(ITypeWithMonoCecil declaringType, MethodInfo method)
        {
            this.method = new MethodWithMonoCecil(declaringType, method);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return method.Attributes; }
        }
        
        public override ITypeWithMonoCecil DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return method.GenericParameters; }
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
    }
}
