using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Numerics;

namespace dayone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // C# Data Types and their Ranges with Descriptions

            // 1. sbyte: Signed 8-bit integer. Range: -128 to 127.
            Console.WriteLine(sbyte.MinValue + " " + sbyte.MaxValue);

            // 2. byte: Unsigned 8-bit integer. Range: 0 to 255.
            Console.WriteLine(byte.MinValue + " " + byte.MaxValue);

            // 3. short: Signed 16-bit integer. Range: -32,768 to 32,767.
            Console.WriteLine(short.MinValue + " " + short.MaxValue);

            // 4. ushort: Unsigned 16-bit integer. Range: 0 to 65,535.
            Console.WriteLine(ushort.MinValue + " " + ushort.MaxValue);

            // 5. int: Signed 32-bit integer. Range: -2,147,483,648 to 2,147,483,647.
            Console.WriteLine(int.MinValue + " " + int.MaxValue);

            // 6. uint: Unsigned 32-bit integer. Range: 0 to 4,294,967,295.
            Console.WriteLine(uint.MinValue + " " + uint.MaxValue);

            // 7. long: Signed 64-bit integer. Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            Console.WriteLine(long.MinValue + " " + long.MaxValue);

            // 8. ulong: Unsigned 64-bit integer. Range: 0 to 18,446,744,073,709,551,615.
            Console.WriteLine(ulong.MinValue + " " + ulong.MaxValue);

            // 9. float: 32-bit single-precision floating-point. Range: ±1.5 x 10^−45 to ±3.4 x 10^38.
            Console.WriteLine(float.MinValue + " " + float.MaxValue);

            // 10. double: 64-bit double-precision floating-point. Range: ±5.0 × 10^−324 to ±1.7 × 10^308.
            Console.WriteLine(double.MinValue + " " + double.MaxValue);

            // 11. decimal: 128-bit precise decimal values with 28-29 significant digits. Range: ±1.0 x 10^-28 to ±7.9 x 10^28.
            Console.WriteLine(decimal.MinValue + " " + decimal.MaxValue);

            // 12. char: Represents a single 16-bit Unicode character. Range: U+0000 to U+FFFF.
            Console.WriteLine(char.MinValue + " " + char.MaxValue);

            // 13. bool: Represents a Boolean value (true or false).
            Console.WriteLine(bool.FalseString + " " + bool.TrueString);

            // 14. string: Represents a sequence of Unicode characters (text).
            Console.WriteLine(string.Empty + " " + "Hello, World!");

            // 15. object: Base type of all types in C#. Can store any data type.
            object obj = "Hello, Object!";
            Console.WriteLine(obj);

            // 16. dynamic: Type resolved at runtime. Can store any type and bypasses compile-time type checking.
            dynamic dyn = "Hello, World!";
            Console.WriteLine(dyn);

            // 17. DateTime: Represents date and time values.
            DateTime now = DateTime.Now;
            Console.WriteLine(DateTime.MinValue + " " + DateTime.MaxValue);
            Console.WriteLine(now);

            // 18. TimeSpan: Represents a time interval (duration).
            TimeSpan timeSpan = new TimeSpan(1, 2, 3, 4, 5);
            Console.WriteLine(timeSpan);

            // 19. Guid: Globally unique identifier (128-bit).
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);

            // 20. BigInteger: Arbitrary-precision integer for very large numbers.
            Console.WriteLine(BigInteger.Zero + " " + BigInteger.One);

            // 21. Tuple: Fixed-size collection of elements of potentially different types.
            var tuple = Tuple.Create(1, "Hello", 3.14);
            Console.WriteLine(tuple);

            // 22. ValueTuple: Lightweight tuple type, supports deconstruction.
            var valueTuple = (1, "Hello", 3.14);
            Console.WriteLine(valueTuple);

            // 23. Array: Fixed-size, zero-based collection of elements of the same type.
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", array));

            // 24. List<T>: Dynamic-size, strongly-typed list of objects.
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", list));

            // 25. Dictionary<TKey, TValue>: Collection of key/value pairs with fast lookup.
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" }
            };
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // 26. HashSet<T>: Unordered collection of unique elements.
            HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", hashSet));

            // 27. Stack<T>: Last-in, first-out (LIFO) collection.
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(string.Join(", ", stack));

            // 28. Queue<T>: First-in, first-out (FIFO) collection.
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine(string.Join(", ", queue));

            // 29. LinkedList<T>: Doubly linked list of nodes.
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            Console.WriteLine(string.Join(", ", linkedList));

            // 30. SortedList<TKey, TValue>: Collection of key/value pairs sorted by key.
            SortedList<int, string> sortedList = new SortedList<int, string>
            {
                { 3, "Three" },
                { 1, "One" },
                { 2, "Two" }
            };
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // 31. SortedDictionary<TKey, TValue>: Sorted dictionary by key, faster insertion/removal than SortedList.
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>
            {
                { 3, "Three" },
                { 1, "One" },
                { 2, "Two" }
            };
            foreach (var kvp in sortedDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // 32. ObservableCollection<T>: Collection that provides notifications when items get added, removed, or when the whole list is refreshed.
            ObservableCollection<int> observableCollection = new ObservableCollection<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", observableCollection));

            // 33. ConcurrentBag<T>: Thread-safe, unordered collection of objects.
            ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();
            concurrentBag.Add(1);
            concurrentBag.Add(2);
            concurrentBag.Add(3);
            Console.WriteLine(string.Join(", ", concurrentBag));

            // 34. ConcurrentQueue<T>: Thread-safe FIFO collection.
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();
            concurrentQueue.Enqueue(1);
            concurrentQueue.Enqueue(2);
            concurrentQueue.Enqueue(3);
            Console.WriteLine(string.Join(", ", concurrentQueue));

            // 35. ConcurrentStack<T>: Thread-safe LIFO collection.
            ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
            concurrentStack.Push(1);
            concurrentStack.Push(2);
            concurrentStack.Push(3);
            Console.WriteLine(string.Join(", ", concurrentStack));

            // 36. BlockingCollection<T>: Thread-safe collection for producer/consumer scenarios.
            BlockingCollection<int> blockingCollection = new BlockingCollection<int>();
            blockingCollection.Add(1);
            blockingCollection.Add(2);
            blockingCollection.Add(3);
            Console.WriteLine(string.Join(", ", blockingCollection));

            // 37. ImmutableArray<T>: Fixed-size, immutable array.
            ImmutableArray<int> immutableArray = ImmutableArray.Create(1, 2, 3, 4, 5);
            Console.WriteLine(string.Join(", ", immutableArray));

            // 38. ImmutableList<T>: Immutable list, cannot be changed after creation.
            ImmutableList<int> immutableList = ImmutableList.Create(1, 2, 3, 4, 5);
            Console.WriteLine(string.Join(", ", immutableList));

            // 39. ImmutableDictionary<TKey, TValue>: Immutable dictionary, cannot be changed after creation.
            ImmutableDictionary<int, string> immutableDictionary = ImmutableDictionary.Create<int, string>()
                .Add(1, "One")
                .Add(2, "Two")
                .Add(3, "Three");
            foreach (var kvp in immutableDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // 40. ImmutableHashSet<T>: Immutable set of unique elements.
            ImmutableHashSet<int> immutableHashSet = ImmutableHashSet.Create(1, 2, 3, 4, 5);
            Console.WriteLine(string.Join(", ", immutableHashSet));

            // 41. ImmutableSortedSet<T>: Immutable sorted set of unique elements.
            ImmutableSortedSet<int> immutableSortedSet = ImmutableSortedSet.Create(3, 1, 2);
            Console.WriteLine(string.Join(", ", immutableSortedSet));

            // 42. ImmutableSortedDictionary<TKey, TValue>: Immutable sorted dictionary.
            ImmutableSortedDictionary<int, string> immutableSortedDictionary = ImmutableSortedDictionary.Create<int, string>()
                .Add(3, "Three")
                .Add(1, "One")
                .Add(2, "Two");
            foreach (var kvp in immutableSortedDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // 43. ReadOnlyCollection<T>: Read-only wrapper around a list.
            ReadOnlyCollection<int> readOnlyCollection = new ReadOnlyCollection<int>(new List<int> { 1, 2, 3, 4, 5 });
            Console.WriteLine(string.Join(", ", readOnlyCollection));

            // 44. ReadOnlyDictionary<TKey, TValue>: Read-only wrapper around a dictionary.
            ReadOnlyDictionary<int, string> readOnlyDictionary = new ReadOnlyDictionary<int, string>(
                new Dictionary<int, string>
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" }
                });
            foreach (var kvp in readOnlyDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // 45. KeyValuePair<TKey, TValue>: Represents a key/value pair.
            KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>(1, "One");
            Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");

            // 46. Span<T>: Stack-only, memory-safe representation of contiguous memory.
            Span<int> span = stackalloc int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", span.ToArray()));

            // 47. Memory<T>: Represents a contiguous region of memory, can be used on heap or stack.
            Memory<int> memory = new int[] { 1, 2, 3, 4, 5 }.AsMemory();
            Console.WriteLine(string.Join(", ", memory.ToArray()));

            // 48. ReadOnlySpan<T>: Read-only stack-only representation of contiguous memory.
            ReadOnlySpan<int> readOnlySpan = stackalloc int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", readOnlySpan.ToArray()));

            // 49. CancellationToken: Propagates notification that operations should be canceled.
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;
            cancellationTokenSource.Cancel();
            Console.WriteLine(cancellationToken.IsCancellationRequested);

            // 50. CancellationTokenRegistration: Represents callback registration with a CancellationToken.
            CancellationTokenRegistration registration = cancellationToken.Register(() => Console.WriteLine("Cancelled!"));
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was cancelled.");
            }
            finally
            {
                registration.Dispose();
            }

            // 51. Task: Represents an asynchronous operation.
            Task task = Task.Run(() => Console.WriteLine("Task is running..."));
            task.Wait();

            // 52. Task<T>: Represents an asynchronous operation that returns a value.
            Task<int> taskWithResult = Task.Run(() =>
            {
                Console.WriteLine("Task with result is running...");
                return 42;
            });
            taskWithResult.Wait();
            Console.WriteLine($"Task result: {taskWithResult.Result}");

            // 53. ValueTask: Lightweight alternative to Task for async operations.
            ValueTask valueTask = new ValueTask(Task.Run(() => Console.WriteLine("ValueTask is running...")));
            valueTask.AsTask().Wait();

            // 54. ValueTask<T>: Lightweight alternative to Task<T> for async operations that return a value.
            ValueTask<int> valueTaskWithResult = new ValueTask<int>(Task.Run(() =>
            {
                Console.WriteLine("ValueTask with result is running...");
                return 42;
            }));
            valueTaskWithResult.AsTask().Wait();
            Console.WriteLine($"ValueTask result: {valueTaskWithResult.Result}");
        }
    }
}
