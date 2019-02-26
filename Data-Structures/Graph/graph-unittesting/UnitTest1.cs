using System;
using Xunit;
using Graph.Classes;

namespace graph_unittesting
{
    public class UnitTest1
    {
        //Node can be successfully added to the graph
        [Fact]
        public void TestAddNode()
        {
            Graph.Classes.Graph testGraph1 = new Graph.Classes.Graph();
            GraphNode test = new GraphNode(5);

        }

            //An edge can be successfully added to the graph


            //A collection of all nodes can be properly retrieved from the graph


            //All appropriate neighbors can be retrieved from the graph


            //Neighbors are returned with the weight between nodes included


            //The proper size is returned, representing the number of nodes in the graph


            //A graph with only one node and edge can be properly returned


            //An empty graph properly returns null


        }
}


//Write tests to prove the following functionality:

//Node can be successfully added to the graph
//An edge can be successfully added to the graph
//A collection of all nodes can be properly retrieved from the graph
//All appropriate neighbors can be retrieved from the graph
//Neighbors are returned with the weight between nodes included
//The proper size is returned, representing the number of nodes in the graph
//A graph with only one node and edge can be properly returned
//An empty graph properly returns null