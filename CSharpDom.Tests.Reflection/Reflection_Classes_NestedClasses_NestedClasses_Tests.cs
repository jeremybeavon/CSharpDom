using CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithBaseClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalNestedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateNestedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedNestedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalNestedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedClassUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedClass));
        }
    }
}
