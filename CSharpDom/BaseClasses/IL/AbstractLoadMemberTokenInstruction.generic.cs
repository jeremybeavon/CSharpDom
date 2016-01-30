using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLoadMemberTokenInstruction<TMemberReference> :
        AbstractLoadMemberTokenInstruction,
        ILoadMemberTokenInstruction<TMemberReference>
    {
        public abstract TMemberReference Member { get; }
    }
}
