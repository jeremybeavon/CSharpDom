using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable.Partial
{
    public abstract class EditablePartialStruct<
        TNamespace,
        TDocument,
        TProject,
        TSolution,
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
        TNestedInterface,
        TNestedStructCollection,
        TStaticConstructor> :
        EditableStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TNamespace : INamespace
        where TDocument : IDocument
        where TProject : IProject
        where TSolution : ISolution
        where TAttributeGroup : IAttributeGroup
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : IStructEventCollection
        where TPropertyCollection : IStructPropertyCollection
        where TIndexerCollection : IStructIndexerCollection
        where TMethodCollection : IPartialStructMethodCollection
        where TFieldCollection : IStructFieldCollection
        where TConstructor : IStructConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IStructNestedClassCollection
        where TNestedDelegate : IStructNestedDelegate
        where TNestedEnum : IStructNestedEnum
        where TNestedInterface : IStructNestedInterface
        where TNestedStructCollection : IStructNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitPartialStruct(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPartialStructChildren(this, visitor);
        }
    }
}
