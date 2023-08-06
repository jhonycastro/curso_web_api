using Core.Entities;
using Core.Repositories;
using Core.Services.Implementations;
using FluentAssertions;
using Moq;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var repoMock = new Mock<IStudentRepository>();
            repoMock.Setups(qq => qq.GetAll()).Returns(new List<Student>());
            var service = new StudentService(repoMock.Object);
            var dtos = service.GetAll();

            dtos.Count.Should().Be(1);
        }
    }
}