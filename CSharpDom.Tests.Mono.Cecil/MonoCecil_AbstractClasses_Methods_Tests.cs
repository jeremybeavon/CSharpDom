using CSharpDom.TestTarget.AbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterAbstractClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualMethodUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualMethod));
        }
    }
}
