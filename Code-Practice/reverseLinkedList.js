// Singly Linked List
class Node {
    constructor(value) {
        this.value = value;
        this.next = null;
    }
}
class LinkedList {
    constructor(value) {
        this.head = {
            value: value,
            next: null,
        };
        this.tail = this.head;
        this.length = 1;
    }
    append(value) {
        const newNode = new Node(value);
        this.tail.next = newNode;
        this.tail = newNode;
        this.length++;
    }
    prepend(value) {
        const newNode = new Node(value);
        newNode.next = this.head;
        this.head = newNode;
        this.length++;
    }
    printList() {
        const array = [];
        let currentNode = this.head;
        while (currentNode !== null) {
            array.push(currentNode.value);
            currentNode = currentNode.next;
        }
        return array;
    }
    insert(index, value) {
        if (index > this.length - 1) {
            this.append(value);
        } else {
            const newNode = new Node(value);
            var previousNode = null;
            var currentNode = this.head;
            var currentNodeIndex = 0;
            while (currentNodeIndex != index) {
                previousNode = currentNode;
                currentNode = previousNode.next;
                currentNodeIndex++;
            }
            previousNode.next = newNode;
            newNode.next = currentNode;
            this.length++;
        }
    }

    remove(index) {
        var previousNode = null;
        var currentNode = this.head;
        var currentNodeIndex = 0;
        while (currentNodeIndex < index && currentNode.next != null) {
            previousNode = currentNode;
            currentNode = currentNode.next;
            currentNodeIndex++;
        }
        previousNode.next = currentNode.next;
        currentNode.next = null;
        this.length--;
    }

    // [1, 10, 16, 88]

    reverse()
    {
        
        var current = this.head;
        var prev = null;
        var next = null;

        while (current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        

        // this.tail = this.head;
        // var current = this.head;
        // var prev = null;
        // var next = null;

        // while (current != null) {
        //     next = current.next;
        //     current.next = prev;
        //     prev = current;
        //     current = next;
        // }
        // this.head = prev;
    }
}

const myLinkedList = new LinkedList(1);
// myLinkedList.append(10);
// myLinkedList.append(16);
// myLinkedList.append(88);
// myLinkedList.prepend(1);
// myLinkedList.insert(2, 99);
// myLinkedList.insert(20, 88);
// myLinkedList.printList();
// myLinkedList.remove(10);
myLinkedList.reverse();
myLinkedList.printList();
console.log(myLinkedList);
