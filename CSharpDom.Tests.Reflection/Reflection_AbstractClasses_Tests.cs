using CSharpDom.TestTarget.AbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith1ImplementedInterface));
        }
        
        [TestMethod]
        public async Task TestAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithBaseClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalAbstractClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(InternalAbstractClass));
        }

        [TestMethod]
        public async Task TestPublicAbstractClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(PublicAbstractClass));
        }
    }
}
