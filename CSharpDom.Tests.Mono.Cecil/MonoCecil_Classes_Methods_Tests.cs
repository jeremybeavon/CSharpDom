using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNewMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNewStaticMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithOverrideMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPrivateMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithPublicMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithStaticMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithVirtualMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithVirtualMethod));
        }
    }
}
