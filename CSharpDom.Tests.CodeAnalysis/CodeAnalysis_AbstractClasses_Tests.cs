using CSharpDom.TestTarget.AbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithBaseClassUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalAbstractClassUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(InternalAbstractClass));
        }

        [TestMethod]
        public async Task TestPublicAbstractClassUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(PublicAbstractClass));
        }
    }
}
