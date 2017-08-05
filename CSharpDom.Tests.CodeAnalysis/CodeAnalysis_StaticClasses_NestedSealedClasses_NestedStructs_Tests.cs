using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicNestedStruct));
        }
    }
}
