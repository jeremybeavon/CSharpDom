using CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedNestedSealedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalNestedSealedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicNestedSealedClass));
        }
    }
}
