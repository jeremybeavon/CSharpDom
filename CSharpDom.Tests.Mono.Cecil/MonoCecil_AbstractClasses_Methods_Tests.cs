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
            TestAbstractClass(typeof(AbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterAbstractClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualMethod));
        }
    }
}
