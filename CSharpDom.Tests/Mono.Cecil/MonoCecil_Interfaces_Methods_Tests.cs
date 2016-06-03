using CSharpDom.TestTarget.Interfaces.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Interfaces_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestIInterfaceWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethod));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithParametersWithModifiers));
        }
    }
}
