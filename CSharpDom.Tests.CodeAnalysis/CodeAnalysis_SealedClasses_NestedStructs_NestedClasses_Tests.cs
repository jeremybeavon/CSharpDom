using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalNestedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateNestedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicNestedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicNestedClass));
        }
    }
}
