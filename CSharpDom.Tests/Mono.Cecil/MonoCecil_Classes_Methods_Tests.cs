using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithInternalMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithOverrideMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithPrivateMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithProtectedMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithPublicMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithStaticMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithVirtualMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
