using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStaticClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalNestedStructUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicNestedStructUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicNestedStruct));
        }
    }
}
