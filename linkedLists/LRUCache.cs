
//Implement the Least Recently Used (LRU) cache class LRUCache. The class should support the following operations

//LRUCache(int capacity) Initialize the LRU cache of size capacity.

//int get(int key) Return the value corresponding to the key if the key exists, otherwise return -1.

//void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. 
//If the introduction of the new pair causes the cache to exceed its capacity, remove the least recently used key.
//A key is considered used if a get or a put operation is called on it.

//Ensure that get and put each run in O(1) average time complexity.




using System;
class HelloWorld {
	static void Main() {
		LRUCache lst = new LRUCache(4);
		lst.Put(1, 3);
		lst.Put(2, 3);
		lst.Put(3, 3);
		lst.Get(3);
		lst.Put(3, 5);
	}

	public class LRUCache {
		private int _capacity;
		private Dictionary<int, Node> _nodeStore = new Dictionary<int, Node>();
		private Node _left;
		private Node _right;

		public class Node {
			public Node prev;
			public Node next;
			public int key;
			public int value;

			public Node(int key, int value) {
				this.key = key;
				this.value = value;
				prev = null;
				next = null;
			}
		}

		public LRUCache(int capacity) {
			_left = new Node(0,0);
			_right = new Node(0,0);
			_left.next = _right;
			_right.prev = _left;
			_capacity = capacity;
		}

		private void addLatest(Node newLatest) {
			Node curLatest = _right.prev;

			curLatest.next = newLatest;
			newLatest.next = _right;
			_right.prev = newLatest;
			newLatest.prev = curLatest;
		}

		private void removeNode(Node nodeToRemove) {
			Node prevNode = nodeToRemove.prev;
			Node nextNode = nodeToRemove.next;

			prevNode.next = nextNode;
			nextNode.prev = prevNode;
		}

		public int Get(int key) {
			if(_nodeStore.ContainsKey(key)) {
				Node node = _nodeStore[key];
				removeNode(node);
				addLatest(node);
				Console.WriteLine($"Successfully retreived key: {key} value: {node.value}");
				return node.value;
			}
            Console.WriteLine($"Retreival Unsuccessful");
			return -1;
		}

		public void Put(int key, int value) {
			if(_nodeStore.ContainsKey(key)) {
				Node node = _nodeStore[key];
				node.value = value;
				removeNode(node);
				addLatest(node);
				Console.WriteLine($"Successfully updated key: {key} value: {value}");
			}
			else {
				Node newNode = new Node(key, value);
				_nodeStore[key] = newNode;
				addLatest(newNode);

				if(_nodeStore.Count()>_capacity) {
					Node leastVisited = _left.next;
					_nodeStore.Remove(leastVisited.key);
					removeNode(leastVisited);
				}
				Console.WriteLine($"Successfully added key: {key} value: {value}");
			}
		}
	}

}





