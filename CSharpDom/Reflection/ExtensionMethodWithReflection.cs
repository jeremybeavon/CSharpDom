using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    /*public sealed class ExtensionMethodWithReflection :
        AbstractExtensionMethod<
            AttributeWithReflection,
            ,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ExtensionParameterWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly MethodWithReflection method;
        private readonly IInternalTypeWithReflection declaringType;

        internal ExtensionMethodWithReflection(IInternalTypeWithReflection declaringType, MethodInfo method)
        {
            this.method = new MethodWithReflection(declaringType, method);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return method.Attributes; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return method.Body; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return method.GenericParameters; }
        }

        public override ExtensionMemberInheritanceModifier InheritanceModifier
        {
            get { return method.MethodInfo.InheritanceModifier(declaringType); }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithReflection> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return method.ReturnType; }
        }

        public override ExtensionMemberVisibilityModifier Visibility
        {
            get { return method.MethodInfo.ExtensionVisibility(); }
        }
    }*/
}
