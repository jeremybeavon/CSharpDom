﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class StructField : IStructField<AttributeGroup, IStructType, TypeReference>
    {
        public StructField()
        {
            Attributes = new List<AttributeGroup>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public IStructType DeclaringType
        {
            get { return null; }
        }

        public TypeReference FieldType { get; set; }

        public FieldModifier Modifier { get; set; }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitFieldChildren(this, visitor);
        }
    }
}
