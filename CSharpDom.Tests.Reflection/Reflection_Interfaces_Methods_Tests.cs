using CSharpDom.TestTarget.Interfaces.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Interfaces_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestIInterfaceWithMethodWith1GenericParameterUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWith2GenericParametersUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethod));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithParametersWithModifiers));
        }
    }
}
