using CSharpDom.TestTarget.AbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(InternalAbstractClass));
        }

        [TestMethod]
        public async Task TestPublicAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(PublicAbstractClass));
        }
    }
}
