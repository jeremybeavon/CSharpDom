using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithBaseClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalClassUsingReflection()
        {
            await TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public async Task TestPublicClassUsingReflection()
        {
            await TestClassAsync(typeof(PublicClass));
        }
    }
}
