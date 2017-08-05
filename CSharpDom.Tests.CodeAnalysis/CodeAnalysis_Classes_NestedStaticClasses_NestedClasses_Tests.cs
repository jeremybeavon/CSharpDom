using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStaticClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicNestedClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedClass));
        }
    }
}
