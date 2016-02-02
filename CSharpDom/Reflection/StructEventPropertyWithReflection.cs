using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructEventPropertyWithReflection :
        AbstractStructEventProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            DelegateReferenceWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        public override ILMethodBodyWithReflectionEmit AddBody
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        
        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ILMethodBodyWithReflectionEmit RemoveBody
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
