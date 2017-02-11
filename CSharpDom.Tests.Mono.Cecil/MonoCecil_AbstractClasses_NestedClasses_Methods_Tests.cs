using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualMethodUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualMethod));
        }
    }
}
