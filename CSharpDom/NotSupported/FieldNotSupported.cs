using System;
using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class FieldNotSupported : VisitableNotSupported<IGenericVisitor>, IClassField
    {
        public ClassFieldModifier Modifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
