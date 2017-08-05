using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicNestedStructUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedStruct));
        }
    }
}
