using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithBaseClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalNestedAbstractClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateNestedAbstractClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedNestedAbstractClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalNestedAbstractClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicNestedAbstractClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicNestedAbstractClass));
        }
    }
}
