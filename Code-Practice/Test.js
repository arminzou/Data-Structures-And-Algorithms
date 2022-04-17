class Stack {
    constructor() {
        this.data = [];
    }
    peek() {
        return this.array[this.array.length - 1];
    }
    push(value) {
        this.data.push(value);
    }
    pop() {
        this.data.pop();
    }
}

var myStack = new Stack();
myStack.push("Google");
myStack.peek();
