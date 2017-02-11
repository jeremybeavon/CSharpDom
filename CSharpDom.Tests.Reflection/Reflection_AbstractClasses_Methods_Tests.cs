using CSharpDom.TestTarget.AbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithMethodWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualMethodUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualMethod));
        }
    }
}
