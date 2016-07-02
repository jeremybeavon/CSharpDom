using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_NestedStructs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalNestedStructUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateNestedStructUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedNestedStructUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedInternalNestedStructUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicNestedStructUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedStruct));
        }
    }
}
