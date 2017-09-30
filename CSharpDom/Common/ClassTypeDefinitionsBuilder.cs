using CSharpDom.BaseClasses;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Common
{
    internal sealed class ClassTypeDefinitionsBuilder : AbstractGenericVisitor, IClassTypeDefinitionsBuilder
    {
        private readonly IList<object> classTypeDefinitions;
        private readonly bool includeNestedClasses;

        public ClassTypeDefinitionsBuilder(IClassCollection classCollection, bool includeNestedClasses)
            : this(includeNestedClasses)
        {
            classCollection.AcceptChildren(this);
        }

        public ClassTypeDefinitionsBuilder(INestedClassCollection classCollection, bool includeNestedClasses)
            : this(includeNestedClasses)
        {
            classCollection.AcceptChildren(this);
        }

        private ClassTypeDefinitionsBuilder(bool includeNestedClasses)
        {
            classTypeDefinitions = new List<object>();
            this.includeNestedClasses = includeNestedClasses;
        }

        public override void VisitAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
        {
            classTypeDefinitions.Add(type);
            if (includeNestedClasses)
            {
                base.VisitAbstractType(type);
            }
        }

        public override void VisitClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            classTypeDefinitions.Add(@class);
            if (includeNestedClasses)
            {
                base.VisitClassType(@class);
            }
        }

        public override void VisitSealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(ISealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
        {
            classTypeDefinitions.Add(type);
            if (includeNestedClasses)
            {
                base.VisitSealedType(type);
            }
        }

        public IEnumerable<TClassTypeDefinition> WithType<TClassTypeDefinition>()
            where TClassTypeDefinition : IClassTypeDefinition
        {
            return classTypeDefinitions.Cast<TClassTypeDefinition>();
        }
    }
}
