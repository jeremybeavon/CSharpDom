using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithBaseClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalNestedAbstractClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateNestedAbstractClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedNestedAbstractClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalNestedAbstractClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicNestedAbstractClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedAbstractClass));
        }
    }
}
