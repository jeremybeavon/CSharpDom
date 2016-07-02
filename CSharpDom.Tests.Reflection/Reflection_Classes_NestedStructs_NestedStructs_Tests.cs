using CSharpDom.TestTarget.Classes.NestedStructs.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedStruct));
        }
    }
}
