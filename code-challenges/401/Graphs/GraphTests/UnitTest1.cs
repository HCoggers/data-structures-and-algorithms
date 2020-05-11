using System;
using Xunit;
using Graphs.Classes;

namespace GraphTests
{
    public class UnitTest1
    {

        /*  
            A graph with only one node and edge can be properly returned
            An empty graph properly returns null 
            */
        [Fact]
        public void CanAddNode()
        {
            Graph<string> test1 = new Graph<string>();
            var a = test1.AddNode("red");

            Assert.Contains(a, test1.GetAllNodes());
        }

        [Fact]
        public void CanAddEdge()
        {
            Graph<string> test2 = new Graph<string>();
            var a = test2.AddNode("red");
            var b = test2.AddNode("orange");
            var c = test2.AddEdge(a, b, 60);
            Assert.Contains(c, test2.AdjacencyList[a]);
        }

        [Fact]
        public void CanGetAllNodes()
        {
            Graph<string> test3 = new Graph<string>();
            test3.AddNode("red");
            test3.AddNode("orange");
            test3.AddNode("yellow");
            Assert.Equal(3, test3.GetAllNodes().Count);
        }

        [Fact]
        public void CanGetNeighbors()
        {
            Graph<string> test4 = new Graph<string>();
            var a = test4.AddNode("red");
            var b = test4.AddNode("orange");
            var c = test4.AddNode("yellow");
            var d = test4.AddEdge(a, b, 60);
            var e = test4.AddEdge(a, c, 60);
            Assert.True(test4.GetNeighbors(a).Contains(d) && test4.GetNeighbors(a).Contains(e));
        }

        [Fact]
        public void CanGetNeighborWeight()
        {
            Graph<string> test5 = new Graph<string>();
            var a = test5.AddNode("red");
            var b = test5.AddNode("orange");
            var d = test5.AddEdge(a, b, 60);
            Assert.Equal(60, test5.GetNeighbors(a)[0].Weight);
        }

        [Fact]
        public void CanGetSize()
        {
            Graph<string> test6 = new Graph<string>();
            test6.AddNode("red");
            test6.AddNode("orange");
            test6.AddNode("yellow");
            Assert.Equal(3, test6.Size());
        }

        [Fact]
        public void CanGetSingleNode()
        {
            Graph<string> test7 = new Graph<string>();
            var a = test7.AddNode("red");

            Assert.Equal(1, test7.Size());
        }

        [Fact]
        public void ReturnsNullForEmpty()
        {
            Graph<string> test8 = new Graph<string>();

            Assert.Null(test8.GetAllNodes());
        }
    }
}
