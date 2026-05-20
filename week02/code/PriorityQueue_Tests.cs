using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities (10, 5, 1) and dequeue them
    // Expected Result: Items come out in order of highest priority first (10, then 5, then 1)
    // Defect(s) Found: Original loop stopped before last item, missing highest priority if at end
    public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();
    
    priorityQueue.Enqueue("Low", 1);
    priorityQueue.Enqueue("High", 10);
    priorityQueue.Enqueue("Medium", 5);
    
    Assert.AreEqual("High", priorityQueue.Dequeue());
    Assert.AreEqual("Medium", priorityQueue.Dequeue());
    Assert.AreEqual("Low", priorityQueue.Dequeue());
}

    [TestMethod]
    // Scenario: Add multiple items where two have same priority (both priority 3)
    // Expected Result: Items with same priority come out in FIFO order (first in, first out)
    // Defect(s) Found: Using >= would pick last equal priority instead of first, breaking FIFO
    public void TestPriorityQueue_2()
{
    var priorityQueue = new PriorityQueue();
    
    priorityQueue.Enqueue("First", 1);
    priorityQueue.Enqueue("Second", 3);
    priorityQueue.Enqueue("Third", 3);
    priorityQueue.Enqueue("Fourth", 5);
    
    Assert.AreEqual("Fourth", priorityQueue.Dequeue());
    Assert.AreEqual("Second", priorityQueue.Dequeue());
    Assert.AreEqual("Third", priorityQueue.Dequeue());
    Assert.AreEqual("First", priorityQueue.Dequeue());
}
    // Add more test cases as needed below.
        [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Throws InvalidOperationException
    // Defect(s) Found: None - exception handling was already in place
    // Test Results: 12/15/2024 - Passed. Correctly throws exception when dequeuing from empty queue.
    public void TestPriorityQueue_3_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
// Scenario: Try to dequeue from an empty queue
// Expected Result: Should throw InvalidOperationException with message "The queue is empty."
// Defect(s) Found: None - exception handling was already implemented
// Test Results: 12/15/2024 - Passed. Correctly throws exception with proper message.
public void TestPriorityQueue_Empty()
{
    var priorityQueue = new PriorityQueue();
    
    var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    Assert.AreEqual("The queue is empty.", exception.Message);
}
}