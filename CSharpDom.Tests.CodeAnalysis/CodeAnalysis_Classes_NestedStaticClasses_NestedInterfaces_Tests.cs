using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStaticClasses_NestedInterfaces_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalNestedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateNestedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedNestedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedInternalNestedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicNestedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedInterface));
        }
    }
}
