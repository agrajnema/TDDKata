using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TDDKata.Queue
{
    public class TestQueue
    {
        private readonly Queue _queue;

        public TestQueue()
        {
            _queue = new Queue(2);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 11)]
        public void Adding_Item_To_List_Should_Increase_Count_By_1(int numberOfItemsToAdd, int expectedCount)
        {
            for (var i = 0; i < numberOfItemsToAdd; i++)
            {
                _queue.Enqueue(i);
            }
            _queue.Count.Should().Be(expectedCount);
        }

        [Fact]
        public void Deleting_Item_From_List_Should_Decrease_Count_By_1()
        {
            var itemDeleted = _queue.Dequeue();
            Assert.Equal(itemDeleted, 2);
            _queue.Count.Should().Be(0);
        }

        [Fact]
        public void Deleting_Item_From_Empty_List_Should_Throw_Exception()
        {
            var itemDeleted = _queue.Dequeue();
            Assert.Equal(itemDeleted, 2);
            _queue.Count.Should().Be(0);
            Assert.Throws<Exception>(() => _queue.Dequeue());
        }
    }
}
