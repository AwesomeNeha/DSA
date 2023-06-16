// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, this program finds the Kth largest element using Priority Queue in C#");

//initialise the priority queue
PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

//creating input array 
int[] nums = new int[6] { 3, 2, 1, 5, 6, 4 };
int k = 2; //find the 2nd largest element

//add numbers to the queue . they will be added in min priority
for (int i = 0; i < nums.Count(); i++)
{
    pq.Enqueue(nums[i], nums[i]);
}

//Dequeue till you are left with only the required number
while (pq.Count > k)
{
    pq.Dequeue();

}

Console.WriteLine("Kth largest element : "+ pq.Peek());
Console.WriteLine();



