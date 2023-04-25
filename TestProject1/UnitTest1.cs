
using ConsoleApp12;
using Moq;

namespace TestProject1
{
    public class Tests
    {
        // MethodName_WhatYouPass_WhatItShouldReturn
        [Test]
        public void Add_ValidInputs_ShouldReturnCorrectAnswer()
        {
            //arrange
            Maths maths = new Maths();
            int a = 3;
            int b = 4;
            int expected = 7;

            //act
            long actual = maths.Add(a,b);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Add_Valid2Inputs_ShouldReturnCorrectAnswer()
        {
            //arrange
            Maths maths = new Maths();
            int a = int.MaxValue;// 2147483647
            int b = int.MaxValue;// 2147483647
            long expected = 4294967294;

            //act
            long actual = maths.Add(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3,4,7)]
        [TestCase(5,6,11)]
        [TestCase(int.MaxValue,int.MaxValue, 4294967294)]
        [TestCase(0,0,0)]
        public void Add_Test_shouldWorkCorrectly(int a, int b, long expected)
        {
            // arrange
            Maths maths = new Maths();

            // act
            long actual = maths.Add(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        // this will actually insert the data into the database/text file
        [Test]
        public void Testt()
        {
            //arrange
            UserManager manger = new UserManager(new DatabaseService());
            UserModel model = new UserModel()
            {
                Email = "usersfdhgj@gmail.com",
                Id = 213,
                Location = "BNGLRhsdgf",
                Name = "TestUserNew",
            };

            // act
            bool actual = manger.AddNewUser(model);

            // assert
            Assert.IsTrue(actual);
        }

        // this will actually insert the data into the database/text file
        [Test]
        public void CorrectTest()
        {
            //arrange
            Mock<IDatabaseService> databaseServiceMock = new Mock<IDatabaseService>();

            // setup
            databaseServiceMock.Setup(x => x.AddUser(It.IsAny<UserModel>())).Returns(true);

            UserManager manger = new UserManager(databaseServiceMock.Object);
            UserModel model = new UserModel()
            {
                Email = "usersfdhgj@gmail.com",
                Id = 213,
                Location = "BNGLRhsdgf",
                Name = "TestUserNew",
            };

            // act
            bool actual = manger.AddNewUser(model);

            // assert
            Assert.IsTrue(actual);
        }

    }
}