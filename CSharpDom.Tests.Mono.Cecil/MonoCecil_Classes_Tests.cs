using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithBaseClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public async Task TestPublicClassUsingMonoCecil()
        {
            await TestClassAsync(typeof(PublicClass));
        }
    }
}
