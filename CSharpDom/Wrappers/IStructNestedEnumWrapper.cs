﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedEnumWrapper :
        IStructNestedEnum<IAttributeGroupWrapper, IStructTypeWrapper, INestedEnumMemberWrapper>
    {
    }
}
