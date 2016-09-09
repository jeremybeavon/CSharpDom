using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableStructType<
        TAttributeGroup,
        TGenericParameter,
        TInterfaceReference,
        TEventCollection,
        TPropertyCollection,
        TIndexerCollection,
        TMethodCollection,
        TFieldCollection,
        TConstructor,
        TOperatorOverload,
        TConversionOperator,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterfaceCollection,
        TNestedStructCollection,
        TStaticConstructor> :
        EditableType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>,
        IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : IStructEventCollection
        where TPropertyCollection : IStructPropertyCollection
        where TIndexerCollection : IStructIndexerCollection
        where TMethodCollection : IStructMethodCollection
        where TFieldCollection : IStructFieldCollection
        where TConstructor : IStructConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IStructNestedClassCollection
        where TNestedDelegate : IStructNestedDelegate
        where TNestedEnum : IStructNestedEnum
        where TNestedInterfaceCollection : IStructNestedInterfaceCollection
        where TNestedStructCollection : IStructNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructType(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructTypeChildren(this, visitor);
        }
    }
}
