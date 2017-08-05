using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithBaseClassUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalNestedAbstractClassUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateNestedAbstractClassUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedNestedAbstractClassUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalNestedAbstractClassUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicNestedAbstractClassUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedAbstractClass));
        }
    }
}
