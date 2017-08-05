using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithBaseClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public async Task TestPublicClassUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(PublicClass));
        }
    }
}
