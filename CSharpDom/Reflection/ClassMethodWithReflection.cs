using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassMethodWithReflection :
        AbstractClassMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly MethodWithReflection method;
        private readonly IInternalTypeWithReflection declaringType;

        internal ClassMethodWithReflection(IInternalTypeWithReflection declaringType, MethodInfo method)
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

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return method.MethodInfo.InheritanceModifier(declaringType); }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return method.ReturnType; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return method.MethodInfo.ClassVisibility(); }
        }
    }
}
