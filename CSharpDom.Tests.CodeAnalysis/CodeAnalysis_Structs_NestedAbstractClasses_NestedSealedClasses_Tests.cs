using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedSealedClass));
        }
    }
}
